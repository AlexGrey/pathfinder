using System;
using System.Collections.Generic;

public class Program {

	public static void Main(String[] args) {
        List<Cell> map = new List<Cell>();

        //blocked cells
        //map.Add(new Cell(0, 1, blocked: true));
        map.Add(new Cell(1, 1, blocked: true));

		for (int x = 0; x < 5; x++) {
			for (int y = 0; y < 5; y++) {
                if (FindCell(x, y, map) == null) {
                    map.Add(new Cell(x, y));
                }
			}
		}

        foreach (var cell in map) {
            if (cell.Y == 4) {
                Console.WriteLine(cell);
            } else {
                Console.Write(cell);
            }
        }

	}

    public static Cell FindCell(int x, int y, List<Cell> map) {
        Cell _cell = null;
        foreach (var cell in map) {
            if (cell.X == x && cell.Y == y) {
                _cell = cell;
            }
        }
        return _cell;
    }
}
