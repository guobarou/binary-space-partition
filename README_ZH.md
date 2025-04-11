[![English](https://img.shields.io/badge/README-English-blue)](./README.md)
[![中文](https://img.shields.io/badge/README-中文-red)](./README_ZH.md)
# 🏰 二叉树空间分割地牢生成器 | Unity 2022 实现

<img src="https://github.com/guobarou/Binary-Space-Partition-Dungeon-Generator/blob/main/Assets/Art/Images/end.png" width="600" style="border-radius:8px; box-shadow:0 4px 8px rgba(0,0,0,0.1)" alt="最终生成效果">

## 📜 技术概述
本系统实现了**二叉树空间分割(BSP)**算法，用于在Unity 2022中生成程序化2D地牢。该方案通过递归空间分割和智能连接策略，创建具有高度可玩性的地牢布局。

## 🔍 核心算法流程

### 1️⃣ 初始空间分割
- 🧩 从矩形边界框开始初始化
- ✂️ 使用二分法递归分割空间
- 🎲 随机选择分割轴（水平/垂直）和位置
- ⏹️ 终止条件：子空间达到预设房间尺寸阈值

<img src="https://github.com/guobarou/Binary-Space-Partition-Dungeon-Generator/blob/main/Assets/Art/Images/1.png" width="500" style="border-radius:8px; box-shadow:0 4px 8px rgba(0,0,0,0.1)" alt="空间分割示意图">

### 2️⃣ 叶节点标识
- 🌳 构建完整的二叉树数据结构
- 🔢 为每个叶节点分配唯一标识符
- 🚪 叶节点对应最终生成的房间单元

<img src="https://github.com/guobarou/Binary-Space-Partition-Dungeon-Generator/blob/main/Assets/Art/Images/2.png" width="500" style="border-radius:8px; box-shadow:0 4px 8px rgba(0,0,0,0.1)" alt="节点标识示意图">

### 3️⃣ 空间关系构建
- 🏗️ 维护完整的树形拓扑结构
- 📐 记录每个节点的空间边界信息
- 🔗 建立父子节点和兄弟节点的连接关系

<img src="https://github.com/guobarou/Binary-Space-Partition-Dungeon-Generator/blob/main/Assets/Art/Images/3.png" width="500" style="border-radius:8px; box-shadow:0 4px 8px rgba(0,0,0,0.1)" alt="完整树结构">

### 4️⃣ 走廊生成算法
- 🛣️ 采用自底向上的遍历策略
- 🤝 在相邻空间之间创建最短路径连接
- 📏 动态调整走廊宽度参数

<img src="https://github.com/guobarou/Binary-Space-Partition-Dungeon-Generator/blob/main/Assets/Art/Images/4.png" width="500" style="border-radius:8px; box-shadow:0 4px 8px rgba(0,0,0,0.1)" alt="走廊生成效果">

### 5️⃣ 围墙系统
- 🧱 8方向邻域检测
- 🔢 基于位掩码的围墙计算
- 📐 自动匹配围墙纹理角度

<img src="https://github.com/guobarou/Binary-Space-Partition-Dungeon-Generator/blob/main/Assets/Art/Images/5.png" width="500" style="border-radius:8px; box-shadow:0 4px 8px rgba(0,0,0,0.1)" alt="围墙生成效果">

## 📦 素材使用声明
所有美术资源均已获得合法授权：
[Pixel Poem的地牢素材包](https://pixel-poem.itch.io/dungeon-assetpuck)

---

**🛠️ 技术栈**  
Unity 2022 | C# | BSP算法 | 程序化生成

**📅 版本信息**  
v1.0 | 最后更新：2023年11月

**👨💻 开发者**  
[guobarou](https://github.com/guobarou)

[![GitHub stars](https://img.shields.io/github/stars/guobarou/Binary-Space-Partition-Dungeon-Generator?style=social)](https://github.com/guobarou/Binary-Space-Partition-Dungeon-Generator)

> 💡 适用于需要程序化地图生成的Roguelike、RPG等游戏类型
