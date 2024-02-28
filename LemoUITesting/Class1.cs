using System;
using System.Drawing;
using System.Windows.Forms; // This is actually not needed for Keys, but for forms functionality
using GTA; // Base namespace for GTA V scripting
using GTA.Math; // For Vector3 and possibly other math related classes
using LemonUI; // Base namespace for LemonUI functionalities
using LemonUI.Menus; // For menu functionalities

namespace Lemon_UI_Car_Spawner_Example
{
    public class Lemon_UI_Car_Spawner_Example : Script
    {
        readonly ObjectPool pool = new ObjectPool();
        NativeMenu menu = new NativeMenu("LS Flight Sim", "Duty menu", "Welcome pilot!");
        NativeItem spawnDubsta = new NativeItem("Spawn Dubsta");

        public Lemon_UI_Car_Spawner_Example()
        {
            Tick += OnTick;
            Aborted += OnAbort;
            KeyDown += OnKeyDown;
            KeyUp += OnKeyUp;

            pool.Add(menu);
            menu.Add(spawnDubsta);
            spawnDubsta.Enabled = true;

            // Subscribe to the Activated event of the spawnDubsta NativeItem
            spawnDubsta.Activated += SpawnDubsta_Activated;
        }

        private void OnTick(object sender, EventArgs e)
        {
            pool.Process();
        }

        private void OnAbort(object sender, EventArgs e)
        {
            // Handle cleanup if necessary
        }

        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            // Add your code here to be executed when a key is initially pressed

            // Example: Check if the J key is pressed
            if (e.KeyCode == Keys.J)
            {
                menu.Visible = true;
            }
        }

        private void OnKeyUp(object sender, KeyEventArgs e)
        {
            // Handle key up events if necessary
        }

        private void SpawnDubsta_Activated(object sender, EventArgs e)
        {
            // Get the player's current position
            Vector3 playerPosition = Game.Player.Character.Position;

            // Calculate a position in front of the player for the Dubsta to spawn
            Vector3 spawnPosition = playerPosition + Game.Player.Character.ForwardVector * 5.0f;

            // Spawn a Dubsta at the calculated position
            Vehicle dubsta = World.CreateVehicle(VehicleHash.Dubsta, spawnPosition);

            // Optionally, set the player as the driver of the Dubsta
            Game.Player.Character.SetIntoVehicle(dubsta, VehicleSeat.Driver);

            
        }
    }
}
