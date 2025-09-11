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

Class snapshots (tags)

At the end of each demo day, a tag is created. You can:

- Just view that snapshot: git checkout <tag>
- Create a working branch starting from that snapshot (recommended): git switch -c main <tag>

List available tags:

git fetch --tags
git tag --sort=-creatordate

⸻

Make a working branch from a specific class tag

Class Tag	Example Working-Branch Name	Command
workshop3-part1-2025-09-08	my-work-part1	bash\ngit fetch --tags\ngit switch -c my-work-part1 workshop3-part1-2025-09-08\n
workshop3-part2-2025-09-10	my-work-part2	bash\ngit fetch --tags\ngit switch -c my-work-part2 workshop3-part2-2025-09-10\n

Replace my-work-part1 / my-work-part2 with whatever branch name you prefer.

⸻

Keep your branch up to date (optional)

If new tags or commits land on main, you can pull updates without disturbing your working branch:

## Update local main and tags

git switch main
git pull --rebase
git fetch --tags

## Go back to your working branch

git switch my-work-part2


⸻

Open in Unity

1. Open Unity Hub → Add → select this repo’s folder.
2. Open the project with Unity 6 (or the version shown in ProjectVersion.txt).
3. Press Play to run the current scene.

⸻

Troubleshooting

- Unity version mismatch: Open with the version listed in ProjectSettings/ProjectVersion.txt.
- Missing sprites/audio: If assets appear missing, ensure Git LFS is installed and run git lfs pull.
- Can’t see tags: Run git fetch --tags first.

⸻

📚 What’s in each part?

- Part 1 (2025-09-08): Project setup, basic player movement
- Part 2 (2025-09-10): Collisions, rigidbody physics, camera follow.
