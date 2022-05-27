using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyGame.Controllers;

namespace MyGame.Models
{
    class Enemy
    {
        private readonly Player player;
        public int positionX;
        public int positionY;

        public int direction;

        public bool isMoving;
        public bool isAttack;

        public int size;
        public Image spriteSheet;

        public int currentAnimation;
        public int currentImageLimit;
        public int currentFrame;
        public int idleFrames;
        public int runFrames;
        public int attackFrames;
        public int deathFrames;

        public int life;

        public int locationIdleFrames;
        public int locationRunFrames;
        public int locationAttackFrames;
        public int locationDeathFrames;

        public bool characterDied = false;

        public Enemy(int posX, int posY, Image spriteSheet, int size, int idleFrames, int runFrames, int attackFrames,
            int deathFrames, Player player, int life, int locationIdleFrames, int locationRunFrames, int locationAttackFrames, int locationDeathFrames)
        {
            positionX = posX;
            positionY = posY;
            direction = 1;
            this.size = size;
            this.spriteSheet = spriteSheet;
            this.idleFrames = idleFrames;
            this.runFrames = runFrames;
            this.attackFrames = attackFrames;
            this.deathFrames = deathFrames;
            currentFrame = 0;
            this.player = player;
            this.life = life;
            this.locationIdleFrames = locationIdleFrames;
            this.locationRunFrames = locationRunFrames;
            this.locationAttackFrames = locationAttackFrames;
            this.locationDeathFrames = locationDeathFrames;
        }

        public void ChangeAnimation(int currentAnimation)
        {
            this.currentAnimation = currentAnimation;
            if (currentAnimation == locationIdleFrames)
                currentImageLimit = idleFrames;
            else if (currentAnimation == locationRunFrames)
                currentImageLimit = runFrames;
            else if (currentAnimation == locationAttackFrames)
                currentImageLimit = attackFrames;
            else if (currentAnimation == locationDeathFrames)
                currentImageLimit = deathFrames;
        }

        public void Move()
        {
            if (characterDied)
                return;
            direction = player.positionX < positionX ? -1 : 1;
            if (IsSeePlayer() && !AttackPlayer())
            {
                ChangeAnimation(locationRunFrames);
                positionX += direction * 2;
            }
            else
            {
                ChangeAnimation(locationIdleFrames);
            }
        }

        public void Battle()
        {
            direction = player.positionX < positionX ? -1 : 1;
            if (AttackPlayer() && !characterDied && !player.characterDied)
            {
                ChangeAnimation(locationAttackFrames);
                player.XP--;
            }

            if (PlayerAttackMe())
            {
                life -= player.weapon.damage;
                //player.weapon.cartridgesCount -= 2;
            }

            if (life <= 0)
            {
                isMoving = false;
                characterDied = true;
                isAttack = false;
                ChangeAnimation(locationDeathFrames);
            }
        }

        public void Fall()
        {
            if (GameControllers.EssenceInAir(positionX, positionY))
            {
                positionY += 2;
                isMoving = false;
            }
            else
            {
                isMoving = true;
            }
        }

        public bool IsSeePlayer()
        {
            var posY = positionY - 16;
            for (var i = 1; i <= 32; i++)
            {
                if (player.positionY == posY + i)
                {
                    isMoving = true;
                    return true;
                }
            }
            return false;
        }

        public bool AttackPlayer()
        {
            return player.positionX - direction * 20 == positionX && IsSeePlayer();
        }

        public bool PlayerAttackMe()
        {
            return IsSeePlayer() && player.isAttack;
        }
    }
}