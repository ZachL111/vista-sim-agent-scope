# vista-sim-agent-scope

`vista-sim-agent-scope` treats simulations as a local verification problem. The C# implementation is intentionally narrow, but the fixtures and notes make the behavior explicit.

## Vista Sim Agent Scope Checkpoints

Treat the compact fixture as the contract and the extended examples as a scratchpad. The code should stay boring enough that a change in behavior is obvious from the test output.

## What This Is For

The repository exists to keep a technical idea small enough to reason about. The implementation avoids external dependencies where possible, then uses fixtures to make changes easy to review.

## Useful Pieces

- Models input state with deterministic scoring and explicit review decisions.
- Uses fixture data to keep policy checks changes visible in code review.
- Includes extended examples for fixture data, including `surge` and `degraded`.
- Documents local reports tradeoffs in `docs/operations.md`.
- Runs locally with a single verification command and no external credentials.

## Architecture Notes

The interesting part is the boundary between accepted and reviewed scenarios. Extended examples sit near that boundary so future edits can show whether the model became more permissive or more cautious. The C# code keeps the core model in a small static API and runs checks through the executable path.

## Project Layout

- `src`: primary implementation
- `tests`: verification harness
- `fixtures`: compact golden scenarios
- `examples`: expanded scenario set
- `metadata`: project constants and verification metadata
- `docs`: operations and extension notes
- `scripts`: local verification and audit commands

## Tooling

The only required setup is the local C# toolchain. After cloning, stay in the repo root so fixture paths resolve correctly.

## Local Workflow

```powershell
powershell -NoProfile -ExecutionPolicy Bypass -File scripts/verify.ps1
```

This runs the language-level build or test path against the compact fixture set.

## Quality Gate

```powershell
powershell -NoProfile -ExecutionPolicy Bypass -File scripts/audit.ps1
```

The audit command checks repository structure and README constraints before it delegates to the verifier.

## Case Study

`baseline` is the first example I would inspect because it lands on the `review` path with a score of 76. The broader file also keeps `degraded` at -66 and `surge` at 214, which gives the model a useful low-to-high spread.

## Scope

The fixture set is deliberately small. That keeps the review surface clear, but it also means the model should not be treated as a complete domain simulator.

## Expansion Ideas

- Add a loader for `examples/extended_cases.csv` and promote selected cases into the language test suite.
- Add a short report command that prints the score breakdown for a single scenario.
- Add malformed input fixtures so the failure path is as visible as the happy path.
- Add one more simulations fixture that focuses on a malformed or borderline input.
