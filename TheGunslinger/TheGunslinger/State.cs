namespace TheGunslinger {
    public class State {
        public string data { get; }
        public int[] next { get; }
        public int action { get; }

        public State(string data, int[] next, int action = -1) {
            this.data = data;
            this.next = next;
            this.action = action;
        }
    }
}
