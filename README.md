# Binary Space Partition Dungeon Generator 🌳🏰

A procedural 2D dungeon generator implemented in Unity 2022 using Binary Space Partitioning (BSP) algorithm.

![Final Result](https://github.com/guobarou/Binary-Space-Partition-Dungeon-Generator/blob/main/Assets/Art/Images/end.png)

## ✨ Features
- ​**BSP Algorithm**: Recursive space partitioning for natural dungeon layouts
- ​**Customizable Parameters**: Control room sizes, corridor widths, and dungeon complexity
- ​**Smart Wall Generation**: 8-directional wall detection with binary operations
- ​**Visual Debugging**: Step-by-step visualization of the generation process

## 🏗️ Implementation Steps

### 1. Space Partitioning
The algorithm starts with a rectangle representing the entire dungeon, then recursively splits it into sub-dungeons with random split positions until reaching desired room sizes.

![Step 1](https://github.com/guobarou/Binary-Space-Partition-Dungeon-Generator/blob/main/Assets/Art/Images/1.png)

### 2. Room Numbering
Generate room numbers based on binary node indices, where leaf nodes become the final rooms.

![Step 2](https://github.com/guobarou/Binary-Space-Partition-Dungeon-Generator/blob/main/Assets/Art/Images/2.png)

### 3. Complete Binary Tree
While only leaf nodes become rooms, we maintain the complete binary tree structure for corridor generation.

![Step 3](https://github.com/guobarou/Binary-Space-Partition-Dungeon-Generator/blob/main/Assets/Art/Images/3.png)

### 4. Corridor Generation
Merge nodes level by level to create natural connecting corridors between rooms.

![Step 4](https://github.com/guobarou/Binary-Space-Partition-Dungeon-Generator/blob/main/Assets/Art/Images/4.png)

### 5. Wall Generation
Using 8-directional binary detection to create properly angled walls around rooms and corridors.

![Step 5](https://github.com/guobarou/Binary-Space-Partition-Dungeon-Generator/blob/main/Assets/Art/Images/5.png)

## 🎮 How to Use
1. Clone the repository
2. Open in Unity 2022+
3. Adjust parameters in the DungeonGenerator script
4. Press Play to generate a new dungeon

## 📜 License & Assets
All game assets used with permission/license from:
[Pixel Poem's Dungeon Asset Pack](https://pixel-poem.itch.io/dungeon-assetpuck)

---

Made with ♥ by [Your Name] | [![GitHub](https://img.shields.io/github/followers/guobarou?style=social)](https://github.com/guobarou)
