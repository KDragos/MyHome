# My Home by Kristin Dragos

## About

My second project for Udacity's Virtual Reality Nanodegree. This project was written with Unity and C# with the goal of creating and lighting a basic scene. Also, this project required some work with animations. The animation for the globe was required. 

# Enhancements

I added a couple of additional features with my version of this project. I added the ability to intercept the teleporter script that fired on every trigger. I only wanted users to move if they were not clicking on something that had an animation on it - a "clickable" object. I added an animation to turn the computer and tv on and off. I also added some running water (particle effects) to the faucet. 

While I was building my scene, I found the "mouse" prefab and started animating it like a rodent... (oops!) Later, I realized that this was actually a computer mouse. I added that prefab to the computer desk, but I also added a real rodent roaming the apartment since I liked the idea. 

## Completion Time

Estimated completion time: 6 hours. 

## Challenges and Reflection

The most challenging part of this project was intercepting the trigger events. I wanted to use the provided teleport script that teleported users to a different location on each trigger. However, I wanted users to be able to click items in the scene and have animations play or actions happen. To solve this, I added some code in the GvrReticle class that will look to see if the selected object has a tag of "Clickable." If it doesn't have the tag, the users will teleport. If the object has the tag, they will stay where they are, and something else will happen. 

I really liked being able to add functionality to my scene. Water comes out of the faucet. The tv and computers can be turned on and off. The globe will spin, and continue to spin until stopped. I also enjoy the realistic feal of the baked lighting.

## Screenshots

You can view some screenshots of the project here: https://goo.gl/photos/sL3pAfLPV7mNXTQD7
