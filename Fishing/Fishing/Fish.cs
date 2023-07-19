using System;
class Fish 
{
    private System.Windows.Forms.PictureBox picture;

    public Fish(int positionX, int positionY, int speed, int distanceX, System.Windows.Forms.PictureBox picture)
    {
        PositionX = positionX;
        PositionY = positionY;
        Speed = speed;
        DistanceX = distanceX;
        this.picture = picture;
    }

    public int PositionX { get; set; }
    public int PositionY { get; set; }
    public int Speed { get; set; }
    public int DistanceX { get; set; }
    public int Hit { get; set; }

    public virtual bool Run(out int x, out int y)
    {

        bool rc = true;
        PositionX += Speed;
        if (PositionX >= DistanceX)
        {
            PositionX = (picture.Size.Width)*-1;
        }
        x = PositionX;
        y = PositionY;

        return rc;
    }

    public void PictureMove(int x, int y)
    {
        picture.Location = new System.Drawing.Point(x, y);
    }
}