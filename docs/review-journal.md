# Review Journal

I treated `vista-sim-agent-scope` as a project where the smallest useful behavior should still be inspectable.

The local checks classify each case as `ship`, `watch`, or `hold`. That gives the project a small review vocabulary that matches its simulations focus without claiming live deployment or external usage.

## Cases

- `baseline`: `input pressure`, score 217, lane `ship`
- `stress`: `state drift`, score 143, lane `ship`
- `edge`: `review cost`, score 167, lane `ship`
- `recovery`: `decision risk`, score 229, lane `ship`
- `stale`: `input pressure`, score 274, lane `ship`

## Note

The useful failure mode here is a wrong decision on a named case, not a vague style disagreement.
