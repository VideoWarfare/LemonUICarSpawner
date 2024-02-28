# Lemon_UI_Car_Spawner_Example

## Overview

This README provides documentation for the `Lemon_UI_Car_Spawner_Example` script, a basic example of using LemonUI to create an in-game menu in GTA V. The script allows spawning a Dubsta vehicle at the player's location.

## Prerequisites

Before using the script, ensure you have the following installed:

- GTA V
- ScriptHookV
- ScriptHookVDotNet
- LemonUI

## Installation

1. Confirm all prerequisites are installed.
2. Download `Lemon_UI_Car_Spawner_Example.cs`.
3. Place the script file into the `scripts` folder within your GTA V directory.

## Usage

Once installed, use the following key to interact with the script:

- Press `J` to open the in-game menu. From there, you can select the "Spawn Dubsta" option.

## Code Structure

- `Lemon_UI_Car_Spawner_Example` extends the `Script` class, managing game interactions through events.
- `ObjectPool pool`: Manages the menu and item lifecycle.
- `NativeMenu menu`: The main in-game menu interface.
- `NativeItem spawnDubsta`: The menu item to spawn the vehicle.

### Key Events

- `OnTick`: Processes menu interactions.
- `OnAbort`: Handles script cleanup.
- `OnKeyDown` and `OnKeyUp`: Detects and processes key inputs.

### Vehicle Spawning

- `SpawnDubsta_Activated`: Defines the logic to spawn the Dubsta vehicle based on the player's current position.

## Contributions

Contributions are welcome. Fork the repository, make your changes, and submit a pull request.

## License

Specify your project's license here, providing a link or a file name if the license text is included in the repository.
