# Laborator 2

### Bolohan Cosmin-Dumitru,3121B

**1**.*Ce este un viewport?*
În OpenGL, o fereastră este o zonă dreptunghiulară pe ecran unde sunt afișate graficele generate de OpenGL. Acesta este un concept important pentru gestionarea cadrelor de afișare, precum și pentru limitarea zonei de afișare a unei scene la o anumită zonă a ecranului.
**2**.*Ce reprezintă conceptul de frames per second (cadre pe secundă) din punctul de vedere al bibliotecii OpenGL?*
Conceptul de „cadre pe secundă” (FPS) în OpenGL reprezintă numărul de cadre (imagini) pe care GPU-ul le poate crea și afișa pe ecran într-o secundă. Cu cât acest număr este mai mare, cu atât animațiile vor apărea mai fluide.
**3**.*Când este rulată metoda OnUpdateFrame()?*
Metoda OnUpdateFrame() este executată în ciclul principal al aplicației OpenGL, la fiecare cadru. Este responsabil pentru actualizarea stării aplicației, a logicii jocului și a oricăror alte operațiuni care trebuie efectuate înainte de a desena următorul cadru grafic.
**4**.*Ce este modul imediat de randare (immediate mode)?*
Modul imediat de randare (immediate mode rendering) este o tehnică de randare în OpenGL care implică desenarea obiectelor sau a graficelor direct în cadru, fără a utiliza un buffer intermediar pentru a stoca date.
**5**.*Care este ultima versiune de OpenGL care acceptă modul imediat?*
OpenGL 3.0 și versiuni ulterioare nu mai acceptă modul imediat de randare.
**6**.*Când este rulată metoda OnRenderFrame()?*
Metoda OnRenderFrame() este rulată în cadrul ciclului principal de afișare după ce au fost actualizate datele cu OnUpdateFrame(). Această metodă este responsabilă pentru desenarea scenei sau a graficii și pentru afișarea rezultatelor pe ecran.
**7**.*De ce este nevoie ca metoda OnResize() să fie executată cel puțin o dată?*
Pentru că această metodă ajustează viewport-ul si reconfigurează aspectul scenei la redimensionare.
**8**.*Ce reprezintă parametrii metodei CreatePerspectiveFieldOfView() și care este domeniul de valori pentru aceștia?*
**a)**fieldOfView (câmpul de vedere): Specifică unghiul de câmp de vedere vertical al camerei.
**b)**aspectRatio (raportul de aspect): Reprezintă raportul între lățimea și înălțimea viewport-ului.
**c)**zNear și zFar: Reprezintă distanța la care se află planurile de apropiere și depărtare pentru clipare (culling) a obiectelor.

