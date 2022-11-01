#!/bin/sh

docker run \
    -d -t \
	--name dotnet-sdk-7-node \
    -v dotnet-sdk-7-code:/root/code \
	dotnet-sdk-7-node

# no ports published!
 
