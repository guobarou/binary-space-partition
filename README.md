🏰 二叉树空间分割(BSP)地牢生成系统 | Unity 2022 实现
https://github.com/guobarou/Binary-Space-Partition-Dungeon-Generator/blob/main/Assets/Art/Images/end.png

📜 技术概览
本系统采用**二叉树空间分割(Binary Space Partitioning)**算法，在Unity 2022环境下实现了一套完整的2D随机地牢生成解决方案。算法通过递归空间划分和智能连接策略，生成具有高度可玩性的地牢布局。

🔍 核心算法流程
1️⃣ 初始空间分割 (Space Partitioning)
🧩 从矩形边界框(Bounding Box)开始初始化
✂️ 采用递归二分法进行空间划分
🎲 随机选择分割轴(水平/垂直)和分割位置
⏹️ 终止条件：子空间达到预设房间尺寸阈值
https://github.com/guobarou/Binary-Space-Partition-Dungeon-Generator/blob/main/Assets/Art/Images/1.png

2️⃣ 叶节点标记 (Leaf Node Identification)
🌳 构建完整二叉树数据结构
🔢 为每个叶节点分配唯一标识符
🚪 叶节点对应最终生成的房间单元
https://github.com/guobarou/Binary-Space-Partition-Dungeon-Generator/blob/main/Assets/Art/Images/2.png

3️⃣ 空间关系构建 (Spatial Relationship)
🏗️ 维护完整的树形结构拓扑关系
📐 记录每个节点的空间边界信息
🔗 建立父子节点和兄弟节点的连接关系
https://github.com/guobarou/Binary-Space-Partition-Dungeon-Generator/blob/main/Assets/Art/Images/3.png

4️⃣ 走廊生成算法 (Corridor Generation)
🛣️ 采用自底向上的遍历策略
🤝 在相邻空间单元间建立最短路径连接
📏 动态调整走廊宽度参数
https://github.com/guobarou/Binary-Space-Partition-Dungeon-Generator/blob/main/Assets/Art/Images/4.png

5️⃣ 围墙系统 (Wall System)
🧱 8邻域方向检测算法
🔢 基于位掩码(Bitmask)的围墙计算
📐 自动匹配不同角度的围墙贴图
https://github.com/guobarou/Binary-Space-Partition-Dungeon-Generator/blob/main/Assets/Art/Images/5.png

📦 资源使用声明
所有美术资源均获得合法授权：
Dungeon Asset Pack by Pixel Poem

🛠️ 技术栈
Unity 2022 | C# | BSP算法 | 程序化生成

📅 版本信息
v1.0 | 最后更新：2023年11月

👨💻 开发者
guobarou

https://img.shields.io/github/stars/guobarou/Binary-Space-Partition-Dungeon-Generator?style=social

💡 本系统适用于Roguelike、RPG等需要程序化地图生成的游戏项目
