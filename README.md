
# ARChemistryCapstone

## Contributors
This project is a CS496 capstone project at Loyola University Maryland. The following students are working on this project:
- Ryan Gehan
- Peter Pressley

This project is developed in collaboration with Ms. Bal and Ms. Ure.

## Project Description
In this project we will create AR chemistry “Experiences”. A library of Exercises done in Augmented Reality that allow the user to
interact with elements and display how different chemical bonds are formed. These experiences will be accessible through a website we will be making so that the students are able
to examine these AR Experiences in one place.

Each experience is a small unity game that allows the user to move or "fly" around the game objects and will be able to interact with them to make the objects display themselves combining.

## Installation Instructions
### Experience Creation
1.) To begin creating an experience you must first download Unity here: https://unity.com/download , this will download UnityHubSetup.exe  
    - Follow the setup executable and install Unity onto your computer.
    
2.) Once you have Unity installed onto your computer download the Unity Project titled Template Experience on the ARChemistryCapstone Github.  
      - Open the template in Unity.
  
3.) Click on the Project tab on the lower left hand corner of the screen. This should open a dropdown containing your project files.  
      - Inside there should be an Assets folder. Go to Assets > Molecules. Elements, Electrons, and Bonds should be displayed in the folder.
    
4.) Click and drag the desired amount of Elements, Electrons or Bonds onto the environment.

5.) Once you have placed the proper amount of objects for the desired compound, click on a electron/bond game object in the Scene hierarchy on the left hand screen.  
      - The object attributes should pop up on the right hand side of the screen. From there click Add Component then type in "ElectronController".  
      - From this component you can adjust the color of the electron/bond when activated, the sound effect played when clicked, as well as the target position.
    
6.) Choose the desired coordinates for the target position of the electron/bond.

7.) Repeat Steps 5 & 6 until desired movement is set.

8.) Next click on Main Camera in the Scene hierarchy on the left hand screen.  
      - The object attributes should pop up on the right hand side of the screen. From there click Add Component then type in "MovementManager".
    
9.) Click on the Elements drop down.  
      - Hit the "+" symbol to bring up an empty Element 0.  
      - Click and drag your element from the Scene hierarchy on the left hand screen and place it in the empty Element 0 box.  
      - Repeat this for each element object in your environment.
    
10.) Click on the Electrons drop down.  
      - Hit the "+" symbol to bring up an empty Electron 0.  
      - Click and drag your electron from the Scene hierarchy on the left hand screen and place it in the empty Electron 0 box.  
      - Repeat this for each electron object in your environment.
    
11.) Click on the Bonds drop down.  
      - Hit the "+" symbol to bring up an empty Bond 0.  
      - Click and drag your bond from the Scene hierarchy on the left hand screen and place it in the empty Bond 0 box.  
      - Repeat this for each bond object in your environment.
    
12.) Click the Element Target Position dropdown.  
      - Enter the desired coordinates for the final target positon of the element.
    
13.) Click the Electron Target Position dropdown.  
      - Enter the desired coordinates for the final target positon of the electron.
    
14.) Click the Bond Target Position dropdown.  
      - Enter the desired coordinates for the final target positon of the bond.
    
15.) Save the project under File > Save, then File > Build Settings.  
      - The build settings window should appear.
    
16.) Scroll and click on "WebGL", if switch platform is available at the bottom, select it, then click on Player Settings > Compression Format > Disabled

17.) Click "Resolution and Presentation" and select PWA

18.) Exit out the player settings window then select "Build"

19.) Choose the folder of your choice to build your new experience to.

20.)  When the build is complete, copy the files and create a new folder in the ARChemistryCapstone Website under the "games" folder for the chapter that you would like to add the experience to.

21.) Paste your files inside of your new folder.

22.) Head to index.html for the desired chapter and copy the hyper reference:  
				   
	<a href="/CHAPTER/games/FOLDERNAME/"><img class="image" src="/resources/IMAGE" alt="IMAGE DESCRIPTION"><a>

23.) Change "CHAPTER" to your desired chapter. ie: ch1, ch2, ch3, ch3.1 etc...
    
24.) Change "FOLDERNAME" to the name of the newly added folder in "games".

25.) Take a screenshot of the game that you just made in Unity, save it, upload it to the resources folder and change "IMAGE" to the name ofthat new image. This will show on the website and hold the link to the experience.

26.) Upload this new code to GitHub and wait a few minutes for the website to update everything.

24.) Play your new experience on the website!

### Website Editing
The file htmlTempleteCode.html is meant to assist you in adding more chapters to the site. 
To create a new chapter:

1.) Create a new file under the "ARChemistryCapstone" folder, name it ch# with the # being the chapter number.

2.) In that folder, create another floder named "games".

3.) Copy the htmlTempleteCode.html into a new file in the new chapter folder and name it "index.html", change the following 
 

 - Tab Name (what shows up at the top of the browser)
 - Title (the name of the chapter ie "Atoms & Atomic Structure")

4.) Change CHAPTER to the file name that you are in. ie ch1, ch2 etc...

5.) Change NAME to the name of the page. ie "Ch. 1 - Atoms & Atomic Structure"

 
## How to Run

## How to Test

## Kanban Board
