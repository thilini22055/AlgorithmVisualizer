# Algorithm Visualizer

A desktop application developed using **C# Windows Forms (.NET)** for visualizing sorting and pathfinding algorithms with step-by-step animations.

## Features

### Sorting Visualizer

Implemented sorting algorithms:

* Insertion Sort
* Quick Sort

Features:

* Animated sorting visualization using bar charts
* Real-time comparison counter
* Random array generation
* Adjustable array size and animation speed
* Start and Reset controls
* Different colors for comparing, swapping, and sorted bars

### Pathfinding Visualizer

Implemented pathfinding algorithm:

* Breadth-First Search (BFS)

Features:

* Interactive grid system
* Place Start and End nodes
* Draw wall/obstacle tiles
* Step-by-step BFS traversal animation
* Final shortest path highlighting
* Adjustable grid size and animation speed
* Clear grid and Start controls
* Validation for missing start/end nodes

## Project Structure

AlgorithmVisualizer
│
├── AlgorithmVisualizer
│   │
│   ├── Properties
│   │
│   ├── AlgorithmVisualizer.csproj
│   ├── App.config
│   ├── Program.cs
│   │
│   ├── MainForm.cs
│   ├── MainForm.Designer.cs
│   ├── MainForm.resx
│   │
│   ├── SortingForm.cs
│   ├── SortingForm.Designer.cs
│   ├── SortingForm.resx
│   │
│   ├── PathfindingForm.cs
│   ├── PathfindingForm.Designer.cs
│   ├── PathfindingForm.resx
│   │
│   ├── Setting.cs
│   ├── Setting.Designer.cs
│   ├── Setting.resx
│   │
│   ├── InsertionSort.cs
│   ├── QuickSort.cs
│   ├── Node.cs
│   │
│   ├── .gitignore
│   └── .gitattributes
│
└── AlgorithmVisualizer.sln
```


## Technologies Used

* C#
* Windows Forms (.NET)
* GDI+ Graphics (`System.Drawing`)
* `System.Windows.Forms.Timer`

## How to Run

1. Open the project in Visual Studio
2. Open `AlgorithmVisualizer.sln`
3. Build the solution
4. Run the application using:

   * `Ctrl + F5`
   * or click **Start**

## Implemented Requirements

* Multi-form WinForms application
* Timer-based animations
* Object-Oriented Programming structure
* Custom algorithm implementations
* Interactive UI controls
* Input validation and error handling

## Author

* Student Name: H.G.T.Yashoda
* Registration Number:CS/2022/055
* Course: CSCI 22042 – Visual Programming
* University of Kelaniya
