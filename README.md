# AeroMessages

This repository contains the definitions for the network packets that feed into our serialization code generator Aero.

Building the AeroMessages project generates the `AeroMessage.dll` that can then be plugged into compatible projects like PacketPeep.

# Status
* Parses virtually all views and messages in 1962 network protocol, with few defiencies.
* Named variables for all views and maybe a third of the messages.
* No other clients supported at the moment.

# Versioning
## GSS
### V66 = 19551

## Matrix
### V25 = 47464

# Related Projects
* [Aero](https://github.com/themeldingwars/Aero) Source generator
* [Packet Peep](https://github.com/themeldingwars/PacketPeep) Uses the generated dll to parse and visualize network captures and replays.
* [Protocol Data](https://github.com/themeldingwars/Sift)
* [Wiki and some packet captures](https://github.com/themeldingwars/Documentation)

This project was created for educational purposes only.
