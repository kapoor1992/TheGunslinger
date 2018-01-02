namespace TheGunslinger {
    public class Roland {
        private static readonly int maxWater = 100;
        private static readonly int maxBullets = 6;
        public int water { get; set; }
        public int bullets { get; set; }

        public Roland() {
            water = maxWater;
            bullets = maxBullets;
        }

        public void drinkWater() {
            water -= 25;
        }

        public void replenishWater() {
            water = maxWater;
        }

        public void fireBullets(int num) {
            bullets -= num;
        }

        public override string ToString() {
            return "Water Level:  " + water + "\n" + "Bullet Count: " + bullets;
        }
    }
}
