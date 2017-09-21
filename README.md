# Pong Remastered
A creative twist on the beloved 70s arcade game. Our development team has retained the simplicity and minimalism that made the original so great, whilst including exciting new features. 

Download and experience the Alpha version of the game here: https://sites.google.com/view/fnsinc/pong-remastered 

Changelog:

v 1.0.1: resolved issues with multiple colliders on the same game object, leading to bugs (e.g. multiple white balls spawned). Only one type of collider per game object should be applied (e.g. one BoxCollider + one CapsuleCollider). Due to the interaction between the square shape of the Red Ball and the collider on the player, there would sometimes be multiple points of contact, meaning that the Physics code was simultaneously called multiple times. As a result, Red Balls sometimes deducted more than one point upon collision with the player.

v 1.0.0: First Alpha version released to the public.
