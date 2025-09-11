# Unity Workshop 3 — CS 276 (Willamette University)

**Project:** 2D Car Game (Class Demo Repo)  
**Engine:** Unity 6 (2D pipeline)

This repository contains the day-by-day demo code for Unity Workshop 3. Each class session is snapshotted with an **annotated tag** so you can check out exactly what we built in class that day, or branch from that point to continue your own work.

---

## Get the code

Clone this repo:

```bash
git clone https://github.com/LucasCordova/UnityClassDemo2D.git
cd UnityClassDemo2D
```

⸻

### Class snapshots (tags)

At the end of each demo day, a tag is created. You can:

- Just view that snapshot using `git checkout <tag_name>`
- Create a working branch starting from that snapshot (recommended): `git switch -c main <tag_name>`

List available tags:

```bash
git fetch --tags
git tag --sort=-creatordate
```

⸻

| Class Tag (`<tag_name>`)       | What's in this Part? |
|----------------------------|----------------------------|
| `workshop3-part1-2025-09-08` | Project setup, basic player movement |
| `workshop3-part2-2025-09-10` | Collisions, rigidbody physics, camera follow |

To create a working branch from a tag, run (e.g., for part 2):

```bash
git fetch --tags
git switch -c my-work-part2 workshop3-part2-2025-09-10
```

*Where `my-work-part2` is the name of your new branch. You can name it whatever you want.*
⸻

Keep your branch up to date (optional)

If new tags or commits land on main, you can pull updates without disturbing your working branch.

## Update local main and tags

```bash
git switch main
git pull --rebase
git fetch --tags
```

## Go back to your working branch

```bash
git switch my-work-part2
```

⸻

## Open in Unity

1. Open Unity Hub → Add → select this repo’s folder.
2. Open the project with Unity 6 (or the version shown in ProjectVersion.txt).
3. Press Play to run the current scene.
