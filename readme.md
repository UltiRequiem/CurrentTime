# CurrentTime

> **Status: archived.** A tiny .NET example from 2022, kept as a reference.

Get the current time on your CLI 🕰

## Run it

You need the [.NET SDK](https://dotnet.microsoft.com/download). The project targets .NET 6, so on a newer SDK change `TargetFramework` in the `.fsproj` first.

```sh
dotnet run
```

It prints the time now, the day, month and year **written in words**, and the full date, for example:

```
The time now is 10:47:54 AM.
We are in the day twenty-eight of the month ten of the year two thousand and twenty-six.
>> October 28th, 2026
Cheers.
```

The words come from the [Humanizer](https://github.com/Humanizr/Humanizer) library's `ToWords()`.

With Docker (there is a [Dockerfile](./Dockerfile)):

```sh
docker build -t current-time .
docker run --rm current-time
```

The code is in [Program.fs](./Program.fs): one small function per value (`timeNow`, `currentWeek`, `currentMonth`, `currentYear`, `currentDay`) and the `printfn` lines that print them.

## Support

Open an Issue, I will check it a soon as possible 👀

If you want to hurry me up a bit
[send me a tweet](https://twitter.com/UltiRequiem) 😆

Consider [supporting me on Patreon](https://patreon.com/UltiRequiem) if you like
my work 🚀

Don't forget to star the repo ⭐

## Versioning

We use [SemVer](http://semver.org) for versioning. For the versions available,
see the [tags](https://github.com/UltiRequiem/CurrentTime/tags).

## Authors

[Eliaz Bobadilla (a.k.a UltiRequiem)](https://ultirequiem.com) - Creator and
Maintainer 💪

See also the full list of
[contributors](https://github.com/UltiRequiem/RandomNumber/contributors) who
participated in this project.

## Licence

Licensed under the MIT License 📄
