FROM mcr.microsoft.com/dotnet/sdk:7.0-jammy

# ssh install based on https://github.com/rastasheep/ubuntu-sshd/blob/master/18.04/Dockerfile
RUN apt-get update -y
RUN apt-get upgrade -y

RUN apt-get install -y openssh-server
RUN mkdir /var/run/sshd

RUN echo 'root:root' |chpasswd
RUN sed -ri 's/^#?PermitRootLogin\s+.*/PermitRootLogin yes/' /etc/ssh/sshd_config
RUN sed -ri 's/UsePAM yes/#UsePAM yes/g' /etc/ssh/sshd_config
RUN mkdir /root/.ssh
RUN apt-get clean && \
    rm -rf /var/lib/apt/lists/* /tmp/* /var/tmp/*
EXPOSE 22

CMD    ["/usr/sbin/sshd", "-D"]

