# NBTExplorer

NBTExplorer is an open-source NBT editor for all common sources of NBT data. It's mainly intended for editing [Minecraft](http://www.minecraft.net) game data.

## TODO list
- [x] Endian selection dialog for opening
- [x] Header and endian dialog for saving
- [ ] Save as?
- [ ] Command-line support for endian conversion
- [ ] Fix dependencies for .NET framework 2.0
- [ ] LE Substrate option for opening with a specific header type (And failing if not that type)
- [ ] LE Substrate fix loading/saving header-less LE files

Loading big-endian files with a header is not supported.

## Supported Formats

NBTExplorer supports reading and writing the following formats:

* Standard NBT files (e.g. level.dat)
* Schematic files
* Uncompressed NBT files (e.g. idcounts.dat)
* Minecraft region files (*.mcr)
* Minecraft anvil files (*.mca)
* Cubic Chunks region files (r2*.mcr, r2*.mca)

## System Requirements

VS automatically modified some project files for newer .NET and that's what I targeted with the APIs, so it might be needed to rewrite the changes to work with older versions.
Tested on Windows 10, should work with Mono and correct packages.
[Also see the original README](https://github.com/jaquadro/NBTExplorer#system-requirements).
If you don't trust the bundled Substrate.dll, you can build your own, [fork source](https://github.com/leha-code/Substrate).