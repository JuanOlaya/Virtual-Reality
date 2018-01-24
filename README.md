# Virtual Reality  (OSVR and Unity)

La entrega del tercer corte consiste en implementar un proyecto en Unity 3D 5.6.3f1 funcional y ejecutable, en parejas o individual con los siguientes elementos:

For this course we use [OSVR](https://github.com/OSVR/OSVR-Unity) as VR framework. OSVR is able to run on any Android device that has gyroscope and accelerometer. To check if your phone is compatible with this VR framework download XXX app 


### 1. Reticle VR

FOTO

Utilizando la retícula VR implementar mínimo (3) tres interacciones diferentes utilizando la retícula VR vista en clase, es decir, las (2) dos interacciones previas del segundo corte y mínimo (1) una interacción nueva. Por ejemplo:
- Rotate GameObjects
- Change Color of GameObjects
- Destroy GameObjects
- Drag and Drop 2D/3D GameObjects
- Add Force to GameObjects (Normal Vector)
- Impact Effect (Explosion Particles)

### 2. Movement in VR

Implementar al menos un método de navegación:
- First Person Character Controller 
  - Jump
- Third Person Character Controller
- Aircraft/Drone Controller
- Motorcycle Controller
- Car Controller

### 3. Software Patterns 
Utilizar de manera adecuada los scripts VR Interactive Item y VR Eye Raycaster de la OpenSource VR que estamos utilizando:
Agregar el script VR Interactive Item a cada objeto para utilizar. Implementar las interacciones VR en este script
Agregar el script VR Eye Raycaster a un sólo GameObject. Por ejemplo, agregarlo al GO de la cámara u ojos

### 4. Class Diagram

Elaborar un diagrama de clases . Es muy parecido al que están elaborando para la Retícula VR

### 5. Build and Run
5.1. Generar una aplicación del proyecto desarrollado en Unity que sea ejecutable en Android. 
5.2. Ejecutar la aplicación en un dispositivo Android. 

Para mejorar el rendimiento pueden configurar la Texture Compression de la siguiente manera en Build Settings:

Imágenes integradas 2

### 6. Interactive Experience
Además, se tendrá muy en cuenta la aplicación del conocimiento adquirido en otras asignaturas de videojuegos y el tiempo invertido por fuera de clase con el propósito de desarrollar una experiencia vivida y convincente siguiendo la historia planteada en el overview del primer corte. Por ejemplo, para enriquecer la experiencia pueden utilizar:

- Non Player Characters (NPC) from [Mixamo](https://www.mixamo.com)
- Waypoints para el caso de mover animales o automóviles
- Textures
- Physics simulation
- Explosion simulation
- Sound Effects 

Jugabilidad: Orientar el videojuego para que incluya conceptos de videojuegos como por ejemplo: puntajes, premios, reglas, enemigos definidos, objetivo del juego y mecánicas convicentes para un videojuego.

### 7.  VR Glasses/Headset and Game Input for the Remote Controller 
For this course is highly recommended to get some budget VR Glasses and a Bluetooth Remote Control compatible with Android devices. A device recomended is the VR-PARK Portable Wireless Bluetooth 3.0 Remote Controller and a plastic headset, for instance, the budget VR Box.

In order to map the buttons of the controller with an Unity app running an Android device please check the following information:

- [KeyCode](https://docs.unity3d.com/ScriptReference/KeyCode.html)
- [Conventional Game Input](https://docs.unity3d.com/Manual/ConventionalGameInput.html)
- [Input.GetKey](https://docs.unity3d.com/ScriptReference/Input.GetKey.html)
- [Input.GetKeyDown](https://docs.unity3d.com/ScriptReference/Input.GetKeyDown.html)
- [Combination of Keys Pressed](https://answers.unity.com/questions/49285/how-can-i-get-a-combination-of-keys-pressed.html)

### 8. Agile Development

Poner el cronograma aunque esté en español
Online Gantt Diagram [TeamGantt](https://www.teamgantt.com/)


### Links:
- [Simulator Sickness Questionnaire](http://w3.uqo.ca/cyberpsy/docs/qaires/ssq/SSQ_va.pdf)  
VERFICAR CON EL LIBRO VR BOOKhttp://www.tandfonline.com/doi/abs/10.1207/s15327108ijap0303_3

- [Google AR and VR Blog](https://blog.google/products/google-vr/)

### VR Apps:
- [NextVR](https://www.nextvr.com/)

# Bibliography
- [The VR Book: Human-Centered Design for Virtual Reality - ACM Books, Jerald (2015) ](https://www.amazon.com/VR-Book-Human-Centered-Virtual-Reality/dp/1970001127/ref=sr_1_1?ie=UTF8&qid=1516756592&sr=8-1&keywords=VR-Book-Human-Centered-Virtual-Reality)

- [Unity Virtual Reality Projects, Linowes (2015)](https://www.amazon.com/dp/178398855X/ref=sspa_dk_detail_0?psc=1&pd_rd_i=178398855X&pd_rd_wg=wDE6o&pd_rd_r=VS6C5Y7P24ZZC3FJ6KR5&pd_rd_w=03w3M)

- [Artificial Reality 2, Krueger (1991)](https://www.amazon.com/Artificial-Reality-2nd-Myron-Krueger/dp/0201522608/ref=sr_1_2?ie=UTF8&qid=1497846274&sr=8-2&keywords=Artificial+Reality)



