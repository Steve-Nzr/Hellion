# Hellion

Hellion is a FlyForFun V15 emulator built with C# and using the .NET Core 1.0 Framework.

This project has been created for learning purposes about the network and game logic problematics on the server-side.

We choose to use the [Ether.Network][ethernetwork] because it provides a clients management system and also a robust packet management system entirely customisable.

## Details

- Language: `C#`
- Framework target : `.NET Core 1.0`
- Application type: `Console`
- Database type : `MySQL`
- External libraries used:
	- [Ether.Network][ethernetwork]
	- EntityFrameworkCore

## Project architecture


![architecture1](/doc/architecture1.png)

This is a simple scheme representing the Hellion architecture.
As we see, you have a total of 4 servers:

- ISC (Inter Server comunication)
- Login Server
- Cluster Server
- World Server


### ISC

The ISC is the InterServer that comunicates with all your servers.
To start any other server, you **must** start the ISC for your servers connect to him.

### Login Server

The login server has it name says, is the Login Server.

### Cluster Server

The Cluster Server is the server who will have all you game channels (World Servers).
You can have an infite number of Clusters.

This server is in charge of the character management. (Creation, deletion)

### World Server

This server represents a channel on the Cluster Server. This is where all the work will be focused during the game time.

----

Of course, you'll need to configure it correctly if you want to link all the servers between them.
Don't worry, tutorials will follow once the World Server can be started.

## How to use

The current version of Hellion doesn't allow any preview. This section will be updated when the emulator will be capable of handling real players.

[ethernetwork]: https://github.com/Eastrall/Ether.Network
