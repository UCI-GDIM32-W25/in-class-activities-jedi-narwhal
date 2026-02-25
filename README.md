# GDIM32 In Class Activities

## Week 1
### Activity 1: 
- start early
- playtest build
- go to unity documentation
- check itch build link work
- use reasources
- push to github

### Activity 2
 1. x=10
  2. x=2
  3. For every frame it will print the debug log console of hello world
  4. MonoBehaviour
  5. It prints the number 10 before the Update method.
  6. It should be _playerTransform variable not the type.
  7. It should be _playerTransform instead.
### Activity 3
[MG1 breakdown Google doc](https://docs.google.com/document/d/11NYqSVvzWFbjYSesEhZULsuZtHzjsLqqcApzmbzIQNQ/edit?tab=t.0)

## Week 2

### Activity 1: 
![IMG_4EB6424F25B5-1](https://github.com/user-attachments/assets/56510163-4f1a-499d-85ec-fed7292e5abd)


### Activity 2
[MG2 commit history](https://github.com/UCI-GDIM32-W25/mg2-oop-review-jedi-narwhal/commits/main/) 
 
 I setup the Unity editor with all the game objects and all its components. I also outlined my methods in the code and added comments to know what to code.

 ## Week 3
 ### Activity 0: 
My partner is named Minjoo.
### Activity 1 and Activity 2:
all code was pushed to the repo.
### Activity 3:
![IMG_2D62A49370B7-1](https://github.com/user-attachments/assets/b3e67adb-67c4-442b-a934-9d237809e05f)

 ## Week 4
 ### Activity 0: 
My partner is named Minjoo.
### Activity 1:
When i run the game, there is only one locator gameobject with the locator script. This is because the rest of the rest of them are destroyed. 
### Activity 2:
![IMG_9032616B385C-1](https://github.com/user-attachments/assets/c8901464-357d-4fb2-b1a1-4f1e334823a0)

### Activity 3:
[MG4 commit history](https://github.com/jedi-narwhal/HW4/commits/main/) 

I setup my unity project in the editor. I also imported the sprites in the unity editor. In addition, I setup the player gameObject in the scene with the sprite, colliders, and rigidbody.

## Week 5
### Activity 1:
I feel like the design it ok. Some things I would do different is split the classes that deal with inheritance into different scripts so that it is more organized. Specifcally, I would seperate them all out so each parent gets their own script and each child gets their own script. I would also find a way not to declare _durability twice and serialize this. 
### Activity 2:
In demo 2, the MVC pattern is explore. The model part is tunable in the inspector, the designer  can tune the game data in the inspector because scriptable objects can hold game data. The view part is the sprite on the screen with the dialogue. The controller is the code setting up for the data to be tuned in the inspector. 
### Activity 3:
- Inheritance:muliple beats share some actions
- Finite State Machine: Need to update the state based on action
- Singleton: calculate score ,make ui show up, audio
### Activity 4:
Attendance: Sonia Mangat, Minjoo Shin, Milla Lucido
 
 [Final Draft Plan](https://docs.google.com/document/d/1t76iuo2Br_0iJsKgst12nwN4ChwI5BFe61iVY1-cFXg/edit?usp=sharing) 

 ## Week 6
 ### Activity #1-Tool Demo
 - Merge Conflicts: Open in VS Code. Edit to desire to solve merge conflict and then commit it. WE can use this in our project to solve issues in our code where someone wrote the same things in the methods.
 - Unity Profiler: Go to window then analysis then profiler. If there is a chart, that means it is bad. You can check if it was your code or someting wrong with unity physics. Phyics problems may include using the wrong colider. Method problems include using too many debug logs and  using get compontent and member variables in Update. We can use this in our project to check to see what is causing a lag in our game if we feel like it is working slowly. We can check if it is our unity methods or unity components.
 -  Gizmos: Create Gizmos script with the specific gizmos you want. Attach it as a component to the gamobjects you want. Gizmos are only visable in scene view. Velocity gizmo can show ridgebody's velocity, shows which which direction ridgebody moves in. Use it to viualize vectors, to show clicks, it is basically a physics problemsolving tool. We can use this in our project to see if an item is aquired and picked up
 - Breakpoints: Used to not know what is going on. Put breakpoint where error is. Run UNity and variable will be active. Hover over varaible to see which is null. Call stack shows methods call to land to you the way you are her. We can use this in our project to debug our code, specifically to makes sure a item is clicked or our singleton works.
 ### Activity #2: Attendance
 Attendance: Sonia Mangat, Milla Lucido
 
 [Final Draft Plan](https://docs.google.com/document/d/1t76iuo2Br_0iJsKgst12nwN4ChwI5BFe61iVY1-cFXg/edit?usp=sharing) 


 ## Week 7
 ### Activity #1- Demo Notes
 NPC and player: you can use raycasting and vectors to show interactions with NPCs. The finite state machine design pattern used to determine state of proximity to the duck and the duck can update accordingly. Raycast is throwing a ray into a scene and seeing if it hits something. You can use a gizmo to draw a raycast. You can see raycast results using hitinfor. If the tree blocks the raycast, the hitinfo is where the raycast hits in order to make sure the line if sight succeeded. Little dots when contact with obstacles (sphere cast), used for NPC's to see their movement. Sphere casts are better than raycast for collisions.
 ### Activity #2: Attendance
 Attendance: Sonia Mangat, Milla Lucido, Minjoo Shin
 
 ### Activity #3: Final Breakdown
![ final breakdown](https://github.com/user-attachments/assets/94bf3b52-8392-4ded-9196-023030ff0c1f)

 ### Activity #4: Tasks with Tracker
 Sonia: Player and item script
 
 Minjoo: setting up UI
 
 Milla: Building scene and uploading assets

 [Task document...Tracker under document tab](https://docs.google.com/document/d/1OFqRcPZ5ifyW1PyqHkWC3omZ_qQ_pCy577yJh6sZSFs/edit?usp=sharing)

 ### Activity #5: Commit History

  [commit history](https://github.com/jedi-narwhal/GDIM32-Final/commits/main/)

  ## Week 8
 ### Activity #1- Demo Notes
 - post processing effects are shaders that affect the way you loook of your entire screen
 - changes everything on screen
 - install package in package manager info
 - make new layer and add component of post-processing volume
 - test effect after getting it
 ### Activity #2: Attendance
 Attendance: Sonia Mangat, Milla Lucido, Minjoo Shin
 
 ### Activity #3: playtest
 Notes:
- Change FOV for camera (reduce)
- Reduce mouse sensitivity
- Make players unable to walk on furniture 
- Good movement
- Unity play has good mouse sensitivity, figure out how to make itch have good sensitivity

 ### Activity #4: Tasks for today and Tracker
Sonia: Player Script
Minjoo: UI Script
Milla: Audio stuff, interior design, lights

 [Task document...Tracker under document tab](https://docs.google.com/document/d/1OFqRcPZ5ifyW1PyqHkWC3omZ_qQ_pCy577yJh6sZSFs/edit?usp=sharing)

 ### Activity #5: Commit History

  [commit history](https://github.com/jedi-narwhal/GDIM32-Final/commits/main/)

 
 
 


