# Unity3d-HW1
## 游戏对象（GameObjects） 和 资源（Assets）的区别与联系
   **游戏对象（GameObjects）**： Base class for all entities in Unity scenes. 

>   游戏对象是所有其他组件 (Component) 的容器。游戏中的所有对象都是包含不同组件 (Component) 的游戏对象 (GameObject)。技术上来讲，可以创建不使用游戏对象 (GameObject) 的组件 (Component)，但是在将其应用于游戏对象 (GameObject) 之前将无法使用它。

   **资源（Assets）**：An asset is representation of any item that can be used in your game or project. An asset may come from a file created outside of Unity, such as a 3D model, an audio file, an image, or any of the other types of file that Unity supports. There are also some asset types that can be created within Unity, such as an Animator Controller, an Audio Mixer or a Render Texture.

    **区别与联系：**

>   对象出现在游戏的场景中，是资源整合的具体表现； 资源可以被多个对象使用，本身也可以进行实例化。 对象一般有玩家、敌人、环境、摄像机等非实体虚拟父类，资源一般包含对象、材质、场景、声音、预设、贴图、脚本、动作等子文件夹，通常可进一步划分。


## 下载几个游戏案例，分别总结资源、对象组织的结构（指资源的目录组织结构与游戏对象树的层次结构）



  上图为 Unity官方实例 Roll-a-ball 中资源的目录组织结构。


## 编写一个代码，使用 debug 语句来验证 MonoBehaviour 基本行为或事件触发的条件

<p>
  <code> 
    
    public class NewBehaviourScript : MonoBehaviour {
      // Use this for initialization
	    void Start () {
        Debug.Log("Start()");
	    }

      private void Awake()
      {
        Debug.Log("Awake()");
      }

      // Update is called once per frame
      void Update () {
        Debug.Log("Update()");
	    }

      private void FixedUpdate()
      {
        Debug.Log("FixUpdate()");
      }

      private void LateUpdate()
      {
        Debug.Log("LateUpdate()");
      }

      private void OnGUI()
      {
        Debug.Log("OnGUI()");
      }

      private void OnDisable()
      {
        Debug.Log("OnDisable()");
      }

      private void OnEnable()
      {
        Debug.Log("OnEnable()");
      } 
    }

  </code>
</p>
运行结果如下：





## 了解 GameObject，Transform，Component 对象

>
>**GameObject**：Unity场景中所有实体的基类。<br/>
>**Transform**：物体的位置，旋转和比例.<br/>
>**Component**：连接到GameObjects的所有对象的基类    <br/>
>

**1.table对象的属性**：Tag 可以用来标记游戏中不同类型的游戏对象。可使用标记（Tags）通过标记（Tags）名称从脚本中快速找到对象。添加新标记时，可以从游戏对象标记弹出窗口中选择。 Layer可以用于仅对某些特定的对象组投射光纤、渲染或应用光照。

**2.table的Transform属性**：Position，Rotation，Scale

**3.table的部件**：Cube（Mesh Filter），Box Collider， Mesh Renderer

**用UML图描述三者（对象，组件，变换）的关系：**



 ## 编写简单代码验证以下技术的实现:

+ 查找对象：
``GameObject table = GameObject.Find("Table");``
+ 添加子对象：
``GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);``
+ 遍历对象树：
``foreach(Transform every in transform)
  {
      Debug.Log(every.gameObject.name);
  }``
+ 清除所有子对象：
``foreach (Transform every in transform)
  {
      Destroy(every.gameObject);
  }``



## 资源预设（Prefabs）与 对象克隆 (clone)  

   **1. 预设（Prefabs）有什么好处？**<br/>
     
>   预设 (Prefabs) 可放入到多个场景中，且每个场景可使用多次。向场景添加一个预设 (Prefab) 时，就会创建它的一个实例。所有预设 (Prefab) 实例都链接到原始预设 (Prefab)，实质上是原始预设的克隆。不管您的工程中有多少个实例，您对预设 (Prefab) 作薄出任何更改时，您会看到这些更改应用于所有实例。适用于批量处理。

   **2. 预设与对象克隆 (clone or copy or Instantiate of Unity Object) 关系？**<br/>
      
>   对于预设，一旦预设发生改变，所有通过预设实例化的对象都会产生相应的变化，而克隆对象不受克隆本体的影响，因此A克隆的对象B不会因为A的改变而相应改变。       

       
   **3.制作 table 预制，写一段代码将 table 预制资源实例化成游戏对象。**

    public GameObject Table;

	  // Use this for initialization
	  void Start () {
        GameObject newTable = (GameObject)Instantiate(Table, transform.position, transform.rotation);
        
    } 

 ## 尝试解释组合模式（Composite Pattern / 一种设计模式）。使用 BroadcastMessage() 方法。

   组合模式，将对象组合成树形结构以表示“部分-整体”的层次结构，组合模式使得用户对单个对象和组合对象的使用具有一致性。

>    The composite pattern describes a group of objects that is treated the same way as a single instance of the same type of object. The intent of a composite is to "compose" objects into tree structures to represent part-whole hierarchies. Implementing the composite pattern lets clients treat individual objects and compositions uniformly.

   **向子对象发送消息。**

   子类对象方法：

    void Calling()
    {
        print("calling");
    }
    
   父类对象方法：

    void Start () 
    {
        this.BroadcastMessage("Calling");
    } 
      










