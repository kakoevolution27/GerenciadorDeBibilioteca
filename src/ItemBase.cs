public abstract class Item
{
    public int ItemId;
    public ItemType ItemType;
    public string? Title;

    public string? Description;
    public string? Author;

    public DateTime CreatedAt;

}

public enum ItemType{Book, Magazine}