using System.Drawing;
using MyGame.Controllers;

namespace MyGame.Models
{
    class Enemy
    {
        private readonly Player Player;
        public int PositionX;
        public int PositionY;

        public int Direction;

        public bool IsMoving;
        public bool IsAttack;

        public int Size;
        public Image SpriteSheet;

        public int CurrentAnimation;
        public int CurrentImageLimit;
        public int CurrentFrame;
        private readonly int IdleFrames;
        private readonly int RunFrames;
        private readonly int AttackFrames;
        private readonly int DeathFrames;

        private int Xp;
        public bool characterDied;

        private readonly int LocationIdleFrames;
        private readonly int LocationRunFrames;
        private readonly int LocationAttackFrames;
        private readonly int LocationDeathFrames;

        public Enemy(int posX, int posY, Image spriteSheet, int size, int idleFrames, int runFrames, int attackFrames,
            int deathFrames, Player player, int xp, int locationIdleFrames, int locationRunFrames, int locationAttackFrames, int locationDeathFrames)
        {
            PositionX = posX;
            PositionY = posY;
            Direction = 1;
            Size = size;
            SpriteSheet = spriteSheet;
            IdleFrames = idleFrames;
            RunFrames = runFrames;
            AttackFrames = attackFrames;
            DeathFrames = deathFrames;
            CurrentFrame = 0;
            Player = player;
            Xp = xp;
            LocationIdleFrames = locationIdleFrames;
            LocationRunFrames = locationRunFrames;
            LocationAttackFrames = locationAttackFrames;
            LocationDeathFrames = locationDeathFrames;
        }

        public void ChangeAnimation(int currentAnimation)
        {
            CurrentAnimation = currentAnimation;
            if (currentAnimation == LocationIdleFrames)
                CurrentImageLimit = IdleFrames;
            else if (currentAnimation == LocationRunFrames)
                CurrentImageLimit = RunFrames;
            else if (currentAnimation == LocationAttackFrames)
                CurrentImageLimit = AttackFrames;
            else if (currentAnimation == LocationDeathFrames)
                CurrentImageLimit = DeathFrames;
        }

        public void Move()
        {
            Fall();
            if (characterDied)
                return;
            if (!IsMoving) return;
            Direction = Player.PositionX < PositionX ? -1 : 1;
            if (IsSeePlayer() && !AttackPlayer() &&
                !PhysicsController.InConflictLeftAndRight(PositionX, PositionY, Direction))
            {
                ChangeAnimation(LocationRunFrames);
                PositionX += Direction * 2;
            }
            else
            {
                ChangeAnimation(LocationIdleFrames);
            }
        }

        public void Battle()
        {
            Direction = Player.PositionX < PositionX ? -1 : 1;
            if (AttackPlayer() && !characterDied && !Player.CharacterDied)
            {
                ChangeAnimation(LocationAttackFrames);
                Player.XP--;
            }

            if (PlayerAttackMe())
            {
                Xp -= Player.Weapon.Damage;
            }

            if (Xp <= 0)
            {
                IsMoving = false;
                characterDied = true;
                IsAttack = false;
                ChangeAnimation(LocationDeathFrames);
            }
        }

        public void Fall()
        {
            if (PhysicsController.EssenceInAir(PositionX, PositionY))
            {
                PositionY += 2;
                IsMoving = false;
            }
            else
            {
                IsMoving = true;
            }
        }

        public bool IsSeePlayer()
        {
            var posY = PositionY - 16;
            for (var i = 1; i <= 32; i++)
            {
                if (Player.PositionY == posY + i)
                {
                    IsMoving = true;
                    return true;
                }
            }
            return false;
        }

        public bool AttackPlayer()
        {
            return (Direction == -1 ? Player.PositionX - Direction * 25 >= PositionX : Player.PositionX - Direction * 25 <= PositionX) && IsSeePlayer();
        }

        public bool PlayerAttackMe()
        {
            return IsSeePlayer() && Player.IsAttackGun;
        }
    }
}