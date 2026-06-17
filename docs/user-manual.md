# 🏗️ Ribbon Generation & Master Folder Tree Architecture

The csRevit Framework completely bypasses complex UI hardcoding. [cite_start]You construct your Revit interface cleanly through standard Windows folders. [cite: 2, 9, 10]

## Natural UI Sort Order Rules
* [cite_start]**Smart Numbering Prefix:** Use numbers to sort components left-to-right or top-to-bottom (e.g., `01_Modify.panel`, `02_Advanced.panel`). [cite: 11]
* **Automatic Strip Engine:** The framework strips the numerical prefix out when compiling inside Revit. [cite_start]`01_Modify.panel` displays cleanly as **Modify** on screen. [cite: 13, 14]

## Folder Suffix Mapping System
* `.tab` — Generates a completely new primary Ribbon Tab inside Revit.
* `.panel` — Creates a structural panel grouping inside that custom tab.
* [cite_start]`.pushbutton` — Registers an instantly clickable standard button command. [cite: 15]
* [cite_start]`.pulldown` — Renders a sleek vertical dropdown context menu. [cite: 17]
* `.splitbutton` — Creates a dynamic split-button where the top half changes to match your last-used action item.
* [cite_start]`.stack` — Compresses up to 3 individual tools vertically to maximize screen real estate. [cite: 17]
