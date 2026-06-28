using OrchardCore.Modules.Manifest;

[assembly: Module(
    Name = "SoftwareRR Utilities",
    Author = "Davor Puzak",
    Website = "https://softwareRR.com",
    Version = "0.0.1",
    Description = "Random utilities",
    Category = "Development Tools"
)]

[assembly: Feature(
    Id = "SoftwareRR.FlowEnhancements",
    Name = "Enhancements for OrchardCore.Flows",
    Description = "Responsive utilities for flow ",
    Dependencies = ["OrchardCore.Flows"],
    Category = "Content"
)]
