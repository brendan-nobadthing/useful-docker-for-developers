FROM mcr.microsoft.com/dotnet/sdk:7.0


# install node via nodesource ppa
# https://github.com/nodesource/distributions#debinstall

RUN apt-get update -y 
RUN apt-get install curl -y

RUN curl -fsSL https://deb.nodesource.com/setup_18.x | bash -
RUN apt-get install -y nodejs

# keep container running
ENTRYPOINT ["tail", "-f", "/dev/null"] 
