namespace KeyManager.Models
{
    [Serializable]
    public class KeyItem : BaseItem//, IEquatable<KeyItem>
    {
        public string? LoginId { get; set; } = null;

        public string? MailAddress { get; set; } = null;

        public string? LoginPassword { get; set; } = null;

        public string? Url { get; set; } = null;

        public string? Remarks { get; set; } = null;

        //public bool Equals(KeyItem? other)
        //{
        //    if (other == null)
        //    {
        //        return false;
        //    }
        //    return this.Id == other.Id;
        //}

        //public override bool Equals(object? obj)
        //{
        //    return Equals(obj as KeyItem);
        //}

        //public override int GetHashCode()
        //{
        //    return Id.GetHashCode();
        //}
    }
}
