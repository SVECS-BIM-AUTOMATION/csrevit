# 🚀 Getting Started & Installation Guide

Welcome to the **csRevit Framework** deployment portal. This guide outlines the standard onboarding workflow required to provision your master synchronization environment and distribute the runtime client to end-user workstations.

---

## 1. Prerequisites & IT Clearances
Before beginning execution, ensure your organization's infrastructure meets the following baseline requirements:

* **Host Environment:** Autodesk Revit (Versions 2019 through 2026 inclusive) installed natively on Windows workstations.
* **Network Storage:** Active read/write credentials to a shared corporate network directory, network-attached storage (NAS), or local folder partition intended to serve as your central automation repository (e.g., `Z:\BIM\csRevit_Master`).
* **Licensing Credentials:** A valid, cryptographically signed Commercial License Key or an active 1-Month Free Trial key provisioned through the official [SVECS Appstore](https://appstore.svecs.in).

---

## 2. Deploying the C# Bootstrapper Engine
The csRevit Framework operates via a lightweight local microkernel bootstrapper that handles user-interface rendering and dynamic command processing.

1. Download the unified executable deployment package (`csRevit_Installer.exe`) directly from your secure account dashboard or procurement email confirmation.
2. Execute the installer package. The bootstrapper securely sets up the localized engine assets within the standard Autodesk application plugin subsystem:
   `C:\Users\%USERNAME%\AppData\Roaming\Autodesk\ApplicationPlugins\csRevit.bundle`
3. *Note for IT Administrators:* For automated multi-machine corporate pushes via Microsoft Intune or SCCM, please contact our enterprise desk to request silent command-line installer arguments (`/quiet` switch packages).

---

## 3. Environment Configuration & Dynamic Synchronization
Because the csRevit Framework decouples your user interface from hardcoded compiled deployment routines, initial configuration takes less than two minutes and completely eliminates standard plugin installation downtime.

1. **Launch Autodesk Revit:** Open any supported version of Revit. Upon initial startup, the framework will prompt you with a secure software activation screen. Paste your corporate license key or trial key to authorize the seat.
2. **Access the Framework Core:** Look at the top application ribbon. Navigate to the newly initialized **csRevit Core** tab and click the **Global Settings** menu icon (represented by the Gear utility glyph).
3. **Map the Master Engine Path:** In the configuration control dashboard, locate the **Master Network Path** field. Link this field directly to your designated shared corporate network tool directory (e.g., `Z:\BIM\csRevit_Master`). 
4. **Execute Hot-Reload Synchronization:** Return to the main ribbon panel under **csRevit Core** and click the prominent **Sync Tools** action button. 

The underlying dynamic sync architecture will immediately read your centralized folder infrastructure, fetch your team's custom tools, and build your entire operational ribbon on the fly—**mid-session, without requiring a Revit application restart.**

---

## 🛟 Corporate Deployment Support
If your corporate network topology utilizes aggressive proxy configurations, specialized firewall barriers, or strict Endpoint Detection and Response (EDR) profiling that restricts file parsing over shared networks, please bypass public repository tracking channels.

Reach out directly to our dedicated engineering support team for private technical assistance:
📩 **Enterprise Support Desk:** [support@svecs.in](mailto:support@svecs.in)
