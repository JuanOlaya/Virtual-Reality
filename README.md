# VIRTUAL REALITY - CARDBOARD  (OSVR and Unity)

This repository is associated with the subject Virtual Reality taught in the university School of Arts and Letters by Juan Olaya in the semester 2017.2. 

For this course we use [Unity 3D](https://unity3d.com/) 5.6.3f1 and [OSVR](https://github.com/OSVR/OSVR-Unity) as VR framework. OSVR is able to run on any Android device provided of a gyroscope and accelerometer. To check if your Android device is compatible, download the [Cardboard App](https://play.google.com/store/apps/details?id=com.google.samples.apps.cardboarddemo&hl=es_419). The following are the components required for the course.


### 1. Reticle VR

<p align="center">
  <a>
    <img src="Images/ReticleVR.png" width=350 height=190>
  </a>
</p>

The Reticle VR or Gaze VR is useful to interact with GameObjects, as follows:
- Rotate GameObjects
- Change Color of GameObjects
- Destroy GameObjects
- Drag and Drop 2D/3D GameObjects
- Add Force to GameObjects (Normal Vector)
- Impact Effect (Explosion Particles)

### 2. Movement in VR
For Virtual Reality in this course we focused in First Person Character Controller as movement for the most of the projects. This movement is able to manage with a Bluetooth Controller as is explained below. As well is possible to map the follwing movements:
- Third Person Character Controller
- Aircraft/Drone Controller
- Motorcycle Controller
- Car Controller

### 3. Software Patterns 
OSVR, as VR framework, allows use concepts such Interactive Item and Eye Raycaster. In order, to use these concepts properly is crucial to add the VR Eye Raycaster script to only one GameObject. For instance, add it to the camera GameObject. Also, add VR Interactive Item script to each GameObject. 

Assignment: Identify the software patterns that have been used by these concepts/scripts.
Recommended Book: [Game Programming Patterns, Nystrom (2014) - Web version](http://gameprogrammingpatterns.com/contents.html)

### 4. Class Diagram

Assignment: Elaborate a Class (Script) Diagram of the Unity project that shows: the relationship among scripts, their attributes, their methods and software patterns. Recommended Book: [Object-Oriented Software Engineering: Practical Software Development Using UML and Java](https://www.amazon.com/Object-Oriented-Software-Engineering-Practical-Development/dp/0077109082)

### 5. Build and Run
Assignment: Install [Android Studio](https://developer.android.com/studio/index.html) in your computer (PC or Mac) and using an Android device compatible with Cardboard, generate an Android app of the Unity VR project and then run the VR app in an Android device. For this assignment is highly recommended use a Cardboard.

In order to enhance the performance of the App, setup the Texture Compression in the Build Settings, as is shown in the following image:

<p align="center">
  <a>
    <img src="Images/BuildAndRun.png" width=450 height=120>
  </a>
</p>

### 6. Interactive Experience
For the video game is relevant includ the concepts of Game Design, such as: goal of the game, score, rules, awards, vivid interactive storytelling and convinving mechanics. Moreover, is important to enrich the experience of the video game with:

- Non Player Characters (NPC) from [Mixamo](https://www.mixamo.com)
- Waypoints (to move characters, animals or vehicles around)
- Textures
- Physics Simulation
- Explosion Simulation
- Sound Effects 


### 7.  VR Glasses/Headset and Game Input for the Remote Controller 
For this course is highly recommended to get some budget VR Glasses and a Bluetooth Remote Control compatible with Android devices. A device recomended is the VR-PARK Portable Wireless Bluetooth 3.0 Remote Controller and a plastic headset, for instance, the budget VR Box.

In order to map the buttons of the controller with an Unity app running an Android device please check the following information:

- [KeyCode](https://docs.unity3d.com/ScriptReference/KeyCode.html)
- [Conventional Game Input](https://docs.unity3d.com/Manual/ConventionalGameInput.html)
- [Input.GetKey](https://docs.unity3d.com/ScriptReference/Input.GetKey.html)
- [Input.GetKeyDown](https://docs.unity3d.com/ScriptReference/Input.GetKeyDown.html)
- [Combination of Keys Pressed](https://answers.unity.com/questions/49285/how-can-i-get-a-combination-of-keys-pressed.html)

### 8. Agile Development for Video Games (Scrum)
According to the Agile methodologies of development, elaborate a Gantt chart in the online tool [TeamGantt](https://www.teamgantt.com/) that takes into account the follwing components:
- Game Design Document (GDD)
- Requirements Elicitation
- Two Scrum Sprints (2nd and 3rd term each) 
- Final delivery (5 minutes pitch)

Recommended Book: [Agile Game Development with Scrum, Keith (2010)](https://www.amazon.com/Agile-Development-Scrum-Addison-Wesley-Signature/dp/0321618521/ref=sr_1_1?ie=UTF8&qid=1516825327&sr=8-1&keywords=agile+game+development+with+scrum)

### VR Links:
- [VR Best Practices - Oculus Dev](https://developer.oculus.com/design/latest/concepts/book-bp/)
- [Simulator Sickness Questionnaire](http://w3.uqo.ca/cyberpsy/docs/qaires/ssq/SSQ_va.pdf)
- [Future of mixed reality - Unity Blog](https://blogs.unity3d.com/2017/09/05/looking-to-the-future-of-mixed-reality-part-i/)
- [3 DOF Vs. 6 DOF](https://www.youtube.com/watch?v=Hu8si8Vgrmg&list=PLBD3ein1xee0HvbbWZxPmt76fISSpAERp&index=17)
- [Degrees of Freedom](http://www.leadingones.com/articles/intro-to-vr-4.html)
- [Google AR and VR Blog](https://blog.google/products/google-vr/)
- [Google Cardboard](https://vr.google.com/cardboard/)

### VR Bibliography
- [The VR Book: Human-Centered Design for Virtual Reality - ACM Books, Jerald (2015)](https://www.amazon.com/VR-Book-Human-Centered-Virtual-Reality/dp/1970001127/ref=sr_1_1?ie=UTF8&qid=1516756592&sr=8-1&keywords=VR-Book-Human-Centered-Virtual-Reality)
- [Agile Game Development with Scrum, Keith (2010)](https://www.amazon.com/Agile-Development-Scrum-Addison-Wesley-Signature/dp/0321618521/ref=sr_1_1?ie=UTF8&qid=1516825327&sr=8-1&keywords=agile+game+development+with+scrum)
- [Unity Virtual Reality Projects, Linowes (2015)](https://www.amazon.com/dp/178398855X/ref=sspa_dk_detail_0?psc=1&pd_rd_i=178398855X&pd_rd_wg=wDE6o&pd_rd_r=VS6C5Y7P24ZZC3FJ6KR5&pd_rd_w=03w3M)
- [A Taxonomy of Mixed Reality Visual Display, Milgram (1994) - Web Version](http://etclab.mie.utoronto.ca/people/paul_dir/IEICE94/ieice.html)
- [Game Programming Patterns, Nystrom (2014) - Web Version](http://gameprogrammingpatterns.com/contents.html)
- [Artificial Reality 2, Krueger (1991)](https://www.amazon.com/Artificial-Reality-2nd-Myron-Krueger/dp/0201522608/ref=sr_1_2?ie=UTF8&qid=1497846274&sr=8-2&keywords=Artificial+Reality)


# STUDENT PROJECTS
The students designed and developed (3) Serious Games and (4) Entertainment Games in the course Virtual Reality taught in the second semester of the year 2017. The video below shows these projects:

<p align="center">
  <a href="https://youtu.be/51uu72lHyX4" target="_blank">
    <img src="Images/YoutubeVideo.png" width=600 height=340>
  </a>
</p>

## EXAMPLE VR APPS
- [Altspace VR](https://altvr.com/)
- [Google Earth VR](https://vr.google.com/earth/)
- [Play Store - Cardboard](https://play.google.com/store/apps/collection/promotion_3001011_cardboard_featured_apps?hl=es_419)
- [NextVR](https://www.nextvr.com/)
- [Discovery VR](https://play.google.com/store/apps/details?id=com.discovery.DiscoveryVR)
- [Apollo 15 Moon Landing VR](https://play.google.com/store/apps/details?id=com.ThomasKole.Apollo15VR)
- [Expeditions](https://play.google.com/store/apps/details?id=com.google.vr.expeditions)
- [Titans of Space VR](https://play.google.com/store/apps/details?id=com.drashvr.titansofspacecb)
- [Owlchemy Labs](https://owlchemylabs.com/)
- [WithIn](https://with.in/)
- [Vimeo 360](https://join.vimeo.com/360/)
- [YouTube VR](https://play.google.com/store/apps/details?id=com.google.android.apps.youtube.vr&hl=es)
- [Google Spotlight Stories](https://play.google.com/store/apps/details?id=com.google.android.spotlightstories&hl=es&rdid=com.google.android.spotlightstories)
- [Cardboard Camera](https://play.google.com/store/apps/details?id=com.google.vr.cyclops)

