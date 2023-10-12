namespace KeyManager.PasswordCreater
{
    internal class Parameter
    {
        public bool Numbers { get; set; }
        public bool Uppercase { get; set; }
        public bool Lowercase { get; set; }
        public bool Symbols { get; set; }
        public int CharLen { get; set; }
        public int CreateCount { get; set; }
    }
}
