# Vista Sim Agent Scope Walkthrough

I use this file as a small checklist before changing the C# implementation.

| Case | Focus | Score | Lane |
| --- | --- | ---: | --- |
| baseline | input pressure | 217 | ship |
| stress | state drift | 143 | ship |
| edge | review cost | 167 | ship |
| recovery | decision risk | 229 | ship |
| stale | input pressure | 274 | ship |

Start with `stale` and `stress`. They create the widest contrast in this repository's fixture set, which makes them better review anchors than the middle cases.

`stale` is the optimistic case; use it to make sure the scoring path still rewards strong signal.
