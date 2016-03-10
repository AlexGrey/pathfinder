using System;

public class Cell {

    int x;
    int y;

    bool blocked = false;
    bool start = false;
    bool finish = false;

    int f;
    int g;
    int h;

    public Cell(int x, int y) {
        this.x = x;
        this.y = y;
    }

    public Cell(int x, int y, bool blocked) {
        this.x = x;
        this.y = y;
        this.blocked = blocked;
    }

    public int X {
        get { return this.x; }
        set { this.x = value; }
    }

    public int Y {
        get { return this.y; }
        set { this.y = value; }
    }

    public bool Blocked {
        get { return this.blocked; }
        set { this.blocked = value; }
    }

    public bool Start {
        get { return this.start; }
        set { this.start = value; }
    }

    public bool Finish {
        get { return this.finish; }
        set { this.finish = value; }
    }

    public int DistanceH(Cell cell) {
        return 10 * (Math.Abs(this.x - cell.x) + Math.Abs(this.y - cell.y));
    }

    public int PriceTo(Cell cell) {
        if (this.x == cell.x || this.y == cell.y) {
            return 10;
        } else {
            return 14;
        }
    }

    public override string ToString() {
        if(this.blocked) {
            return "#";
        }
        return ".";
    }
}
