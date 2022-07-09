namespace PlayerProps
{
    public static class Player
    {
        //Movement
        public static float CameraSpeed { get; set; }
        public static float BoostFactor { get; set; } = 1.0f;
        public static float MoveSpeed { get; set; } = 5.0f;
        public static float BlinkFactor { get; set; } = 5.0f * 1000;

        //Shooting
        public static float AttackSpeed { get; set; } = 5.0f;
        public static float BulletForce { get; set; } = 30.0f;

        //Health
        public static float MaxHealth { get; set; } = 100.0f;
        public static float CurrentHealth { get; set; }
    }
}