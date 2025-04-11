# 🏰 Binary Space Partitioning Dungeon Generator | Unity 2022 Implementation

<div style="text-align:center">
    <img src="https://github.com/guobarou/Binary-Space-Partition-Dungeon-Generator/blob/main/Assets/Art/Images/end.png" alt="Final Generation Result" style="max-width:90%; border-radius:8px; box-shadow:0 4px 8px rgba(0,0,0,0.1)">
</div>

## 📜 Technical Overview
This system implements a ​**Binary Space Partitioning (BSP)** algorithm to generate procedural 2D dungeons in Unity 2022. The solution features recursive space division and intelligent connection strategies to create highly playable dungeon layouts.

## 🔍 Core Algorithm Workflow

### 1️⃣ Initial Space Partitioning
- 🧩 Initializes from a rectangular bounding box
- ✂️ Recursively divides space using binary splitting
- 🎲 Randomly selects split axis (horizontal/vertical) and position
- ⏹️ Termination condition: subspace reaches preset room size threshold

<div style="text-align:center">
    <img src="https://github.com/guobarou/Binary-Space-Partition-Dungeon-Generator/blob/main/Assets/Art/Images/1.png" alt="Space Partitioning Diagram" style="max-width:90%; border-radius:8px; box-shadow:0 4px 8px rgba(0,0,0,0.1)">
</div>

### 2️⃣ Leaf Node Identification
- 🌳 Constructs complete binary tree data structure
- 🔢 Assigns unique identifiers to each leaf node
- 🚪 Leaf nodes correspond to final room units

<div style="text-align:center">
    <img src="https://github.com/guobarou/Binary-Space-Partition-Dungeon-Generator/blob/main/Assets/Art/Images/2.png" alt="Node Identification Diagram" style="max-width:90%; border-radius:8px; box-shadow:0 4px 8px rgba(0,0,0,0.1)">
</div>

### 3️⃣ Spatial Relationship Construction
- 🏗️ Maintains complete tree topology
- 📐 Records spatial boundary information for each node
- 🔗 Establishes parent-child and sibling connections

<div style="text-align:center">
    <img src="https://github.com/guobarou/Binary-Space-Partition-Dungeon-Generator/blob/main/Assets/Art/Images/3.png" alt="Complete Tree Structure" style="max-width:90%; border-radius:8px; box-shadow:0 4px 8px rgba(0,0,0,0.1)">
</div>

### 4️⃣ Corridor Generation Algorithm
- 🛣️ Implements bottom-up traversal strategy
- 🤝 Creates shortest path connections between adjacent spaces
- 📏 Dynamically adjusts corridor width parameters

<div style="text-align:center">
    <img src="https://github.com/guobarou/Binary-Space-Partition-Dungeon-Generator/blob/main/Assets/Art/Images/4.png" alt="Corridor Generation Result" style="max-width:90%; border-radius:8px; box-shadow:0 4px 8px rgba(0,0,0,0.1)">
</div>

### 5️⃣ Wall System
- 🧱 8-direction neighborhood detection
- 🔢 Bitmask-based wall calculation
- 📐 Automatic wall texture angle matching

<div style="text-align:center">
    <img src="https://github.com/guobarou/Binary-Space-Partition-Dungeon-Generator/blob/main/Assets/Art/Images/5.png" alt="Wall Generation Result" style="max-width:90%; border-radius:8px; box-shadow:0 4px 8px rgba(0,0,0,0.1)">
</div>

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
