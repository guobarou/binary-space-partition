# 🏰 Binary Space Partitioning Dungeon Generator | Unity 2022 Implementation

<p align="center">
  <img src="https://github.com/guobarou/Binary-Space-Partition-Dungeon-Generator/blob/main/Assets/Art/Images/end.png" width="90%" style="border-radius:8px; box-shadow:0 4px 8px rgba(0,0,0,0.1)" alt="Final Generation Result">
</p>

## 📜 Technical Overview
This system implements a ​**Binary Space Partitioning (BSP)** algorithm to generate procedural 2D dungeons in Unity 2022. The solution features recursive space division and intelligent connection strategies to create highly playable dungeon layouts.

## 🔍 Core Algorithm Workflow

### 1️⃣ Initial Space Partitioning
- 🧩 Initializes from a rectangular bounding box
- ✂️ Recursively divides space using binary splitting
- 🎲 Randomly selects split axis (horizontal/vertical) and position
- ⏹️ Termination condition: subspace reaches preset room size threshold

<p align="center">
  <img src="https://github.com/guobarou/Binary-Space-Partition-Dungeon-Generator/blob/main/Assets/Art/Images/1.png" width="90%" style="border-radius:8px; box-shadow:0 4px 8px rgba(0,0,0,0.1)" alt="Space Partitioning Diagram">
</p>

### 2️⃣ Leaf Node Identification
- 🌳 Constructs complete binary tree data structure
- 🔢 Assigns unique identifiers to each leaf node
- 🚪 Leaf nodes correspond to final room units

<p align="center">
  <img src="https://github.com/guobarou/Binary-Space-Partition-Dungeon-Generator/blob/main/Assets/Art/Images/2.png" width="90%" style="border-radius:8px; box-shadow:0 4px 8px rgba(0,0,0,0.1)" alt="Node Identification Diagram">
</p>

### 3️⃣ Spatial Relationship Construction
- 🏗️ Maintains complete tree topology
- 📐 Records spatial boundary information for each node
- 🔗 Establishes parent-child and sibling connections

<p align="center">
  <img src="https://github.com/guobarou/Binary-Space-Partition-Dungeon-Generator/blob/main/Assets/Art/Images/3.png" width="90%" style="border-radius:8px; box-shadow:0 4px 8px rgba(0,0,0,0.1)" alt="Complete Tree Structure">
</p>

### 4️⃣ Corridor Generation Algorithm
- 🛣️ Implements bottom-up traversal strategy
- 🤝 Creates shortest path connections between adjacent spaces
- 📏 Dynamically adjusts corridor width parameters

<p align="center">
  <img src="https://github.com/guobarou/Binary-Space-Partition-Dungeon-Generator/blob/main/Assets/Art/Images/4.png" width="90%" style="border-radius:8px; box-shadow:0 4px 8px rgba(0,0,0,0.1)" alt="Corridor Generation Result">
</p>

### 5️⃣ Wall System
- 🧱 8-direction neighborhood detection
- 🔢 Bitmask-based wall calculation
- 📐 Automatic wall texture angle matching

<p align="center">
  <img src="https://github.com/guobarou/Binary-Space-Partition-Dungeon-Generator/blob/main/Assets/Art/Images/5.png" width="90%" style="border-radius:8px; box-shadow:0 4px 8px rgba(0,0,0,0.1)" alt="Wall Generation Result">
</p>

## 📦 Asset Usage Declaration
All art assets are legally licensed:
[Dungeon Asset Pack by Pixel Poem](https://pixel-poem.itch.io/dungeon-assetpuck)

---

**🛠️ Tech Stack**  
Unity 2022 | C# | BSP Algorithm | Procedural Generation

**📅 Version Info**  
v1.0 | Last Updated: November 2023

**👨💻 Developer**  
[guobarou](https://github.com/guobarou)

[![GitHub stars](https://img.shields.io/github/stars/guobarou/Binary-Space-Partition-Dungeon-Generator?style=social)](https://github.com/guobarou/Binary-Space-Partition-Dungeon-Generator)

> 💡 Ideal for Roguelike, RPG and other games requiring procedural map generation
