using System;
using System.Collections.Generic;

public class Program {

	public static void Main(String[] args) {
        List<Cell> map = new List<Cell>();

        //blocked cells
        map.Add(new Cell(0, 0, "start"));
        map.Add(new Cell(0, 2, "finish"));
        map.Add(new Cell(0, 1, "blocked"));
        map.Add(new Cell(1, 1, "blocked"));
        map.Add(new Cell(2, 1, "blocked"));
        map.Add(new Cell(3, 1, "blocked"));

		for (int x = 0; x < 5; x++) {
			for (int y = 0; y < 5; y++) {
                if (FindCell(x, y, map) == null) {
                    map.Add(new Cell(x, y));
                }
			}
		}


        for (int x = 0; x < 5; x++) {
            for (int y = 0; y < 5; y++) {
                if (y == 4) {
                    Console.WriteLine(FindCell(x, y, map));
                } else {
                    Console.Write(FindCell(x, y, map));
                }

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
