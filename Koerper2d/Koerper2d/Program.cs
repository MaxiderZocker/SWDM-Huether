// See https://aka.ms/new-console-template for more information
using Koerper2d;

Koerper2ds mein2DKoerper = new Koerper2ds();
mein2DKoerper.setLaenge(5);
mein2DKoerper.setBreite(5);
Console.WriteLine("Die Fläche beträgt: " + mein2DKoerper.getFlaeche());
Console.WriteLine(mein2DKoerper.getName());

Koerper3d meinKoerper3d = new Koerper3d();
meinKoerper3d.setLaenge(5);
meinKoerper3d.setBreite(5);
meinKoerper3d.setHoehe3d(10);
Console.WriteLine(meinKoerper3d.getName().ToString());
Console.WriteLine(meinKoerper3d.getVolumen().ToString());