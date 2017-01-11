# Hellion

[![Build Status](https://travis-ci.org/Eastrall/Hellion.svg?branch=develop)](https://travis-ci.org/Eastrall/Hellion)

Hellion is a FlyForFun V15 emulator built with C# and using the .NET Core 1.0 Framework.

This project has been created for learning purposes about the network and game logic problematics on the server-side.

We choose to use the [Ether.Network][ethernetwork] because it provides a clients management system and also a robust packet management system entirely customisable.

## Details

- Language: `C#`
- Framework target : `.NET Core 1.0`
- Application type: `Console`
- Database type : `MySQL`
- Configuration files type: `JSON`
- External libraries used:
	- [Ether.Network][ethernetwork]
	- EntityFrameworkCore


## Project features

- InterServer communication (ISC)
- Login Server
- Cluster Server
    - Create/Delete character
    - LoginProtect (On/Off on configuration file)
    - Select character
- World Server
    - Data loading
      - Defines / Texts
      - Items
      - Maps
      - Npc
    - Player login
    - Player visibility with other players
    - Player moves
    - Player attributes
    - NPC
      - Visibility
    - Inventory
      - Move / Equip / Unequip
    - Monsters
      - Visibility
      - Moves
    
## Todo list

- Chat
- NPC
    - Shops
    - Dialogs
- Inventory
  - Use items
  - Create items
  - Sets bonus
- Battle system
- Skills
- Quest system
- Friends
- Mails
- Guilds


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

1. Clone this repository
2. Install MySQL Server on your computer/server
3. Execute the `sql/hellion.sql` file in your MySQL server to setup the database.
4. Configure the 4 servers (ISC, Login, Cluster, World)
5. Restore all dependencies using `restore.bat`
6. Start the servers
   - Start `binar/ISC.bat`
   - Start `binary/LoginServer.bat`
   - Start `binary/ClusterServer.bat`
   - Start `binary/WorldServer.bat`
7. You are now ready to play!

[ethernetwork]: https://github.com/Eastrall/Ether.Network
