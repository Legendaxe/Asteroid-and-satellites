# Satellites



In some part of the space, there is a stationary asteroid with a unique mineral. To precisely locate it, a new type of simple disposable probes has been developed that, when activated, determine the exact distance from themselves to the asteroid once.

It is necessary to write a function that will set the activation coordinates for the probes and, receiving the distances from each of them to the asteroid, will find the coordinates of the asteroid, using the smallest number of probes.

To simplify the problem, let's assume that the part of space where the rare asteroid is located and where probes can be launched is bounded by an imaginary cube measuring 100x100x100. The coordinates of the asteroid and probes can only be integers from 0 to 100.

Input parameters:
To select the asteroid's coordinates, it is necessary to write a function that generates a random location for the asteroid a(x, y, z). Also, it is necessary to prepare a separate function that, given the probe's coordinates, will return the distance between it and the point a.

Need to write a program that will find the coordinates of the asteroid using the minimum possible number of satellites.
