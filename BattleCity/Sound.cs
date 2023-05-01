using System.Media;

namespace BattleCity
{
    /// <summary>
    /// Quản lý tất cả âm thanh có trong trò chơi
    /// </summary>
    static class Sound
    {
// Fields
        private static readonly SoundPlayer clipBurst = new SoundPlayer(Properties.Resources.burst2);
        private static readonly SoundPlayer clipHurt = new SoundPlayer(Properties.Resources.hurtClip);
        private static readonly SoundPlayer clipZombieShoot = new SoundPlayer(Properties.Resources.gun_laser_mav);
        private static readonly SoundPlayer clipPlayerShoot = new SoundPlayer(Properties.Resources.laserClip);
        private static readonly SoundPlayer clickSound = new SoundPlayer(Properties.Resources.click_room);
        private static readonly SoundPlayer selectSound = new SoundPlayer(Properties.Resources.select_sound);
        private static readonly SoundPlayer startSound = new SoundPlayer(Properties.Resources.start);
        private static readonly SoundPlayer takeItemSound = new SoundPlayer(Properties.Resources.prop);

        private static readonly SoundPlayer gameOverSound = new SoundPlayer(Properties.Resources.Gameover);

// Methods
// Âm thanh player bắn
        public static void PlayPlayerShoot()
        {
            clipPlayerShoot.Play();
        }

// Âm thanh attacker bắn
        public static void PlayAttackerShoot()
        {
            clipPlayerShoot.Play();
        }

// Âm thanh attacker nổ
        public static void PlayAttackerBurst()
        {
            clipBurst.Play();
        }

// Âm thành click button
        public static void PlayClickSound()
        {
            clickSound.Play();
        }

// Âm thành select
        public static void PlaySelectSound()
        {
            selectSound.Play();
        }

// Âm thanh Bắt đầu game
        public static void PlayStartSound()
        {
            startSound.Play();
        }

// Âm thanh player lấy được item
        public static void PlayTakeItemSound()
        {
            takeItemSound.Play();
        }

// Âm thanh khi game over
        public static void PlayGameOverSound()
        {
            gameOverSound.Play();
        }
    }
}