using Airsoft.Facade;

Pistola pistola = new Pistola();
Rifle rifle = new Rifle();
AssaultRifle ar = new AssaultRifle();

Aluguel facade = new Aluguel(pistola, rifle, ar);
Client.ClientMethod(facade);