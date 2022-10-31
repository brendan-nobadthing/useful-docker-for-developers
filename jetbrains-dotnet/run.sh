#!/bin/sh

docker run -d \
	--name rider-dev \
	-p 2222:22 \
	dotnet-sdk-ssh
 
