#!/bin/sh


docker run \
-e DISPLAY=$DISPLAY \  
--net=host \ 
gimp:latest 