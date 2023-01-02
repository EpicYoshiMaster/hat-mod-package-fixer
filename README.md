# Hat Mod Package Fixer

A tool designed to assist in changing the PackageVersion property of A Hat in Time mod packages.

This property can cause some versions to not accept mods as playable if they're from a newer version than expected.

Essentially, it allows you to forcibly downpatch mods to be compatible with any version of the game.

I make no guarantees that a mod will work correctly if its PackageVersion has been changed! Use at your own risk!

## Tool Usage

1. Open HatModPackageFixer.exe (go through any warnings, etc.)

2. Press 'Open Mod Directory...' and select a folder containing Mods (ex. .../HatinTime/HatinTimeGame/Mods)

3. All of the Mods in that folder should now appear in a box on-screen with checkboxes, the number in parentheses is the Package Version associated with that Mod

4. Checkmark the Mods you would like to change

5. Select the relevant Old Package Version, which is the version the Package Fixer should replace, or checkmark 'Change Any Version' which will replace all Package Versions

6. Select the New Package Version you would like to change the selected Mods to.

7. Press 'Change Mod Package Versions' to apply the Package Version to your Mods!

8. Complete!

## Relevant Package Versions

893 - Current Patch (as of 1/1/2023)

889 - Auto Jump Patches

888 - DLC 2 w/ Mods Versions (ex. "TAS Patch", "110% Patch")

...Technically you can go beyond, but Mods are very unlikely to work without being recooked for much older builds

Note: Package Versions are backwards compatible, meaning that a mod with version 888 would work on a version using PackageVersion 889, but not vice-versa.

## Identifying Version Generations

Please see the [A Hat in Time Versions Spreadsheet](https://docs.google.com/spreadsheets/d/1AJfZ7t-bZL08atdcdo6p1aFbziEkxxKpHLU9AEuYeB8/edit?usp=sharing) for more information on relevant versions of A Hat in Time for use with this tool.