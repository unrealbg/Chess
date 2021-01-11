namespace Chess.Models
{
    public abstract class BasePositionModel : BaseModel
    {
        public int Row { get; set; }

        public int Col { get; set; }

    }
}
