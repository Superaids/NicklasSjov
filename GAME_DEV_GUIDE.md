# Portable game development guide

**Shared policy 2026-11-01.1, 1 November 2026.** This compact foundation travels with projects when the full private [Game Development Bible](https://github.com/Superaids/general-rules/blob/main/game-dev-bible/00-START-HERE.md) cannot be fetched. Read `GENERAL_RULES.md` and the project's current instructions, accepted direction and handover. When authenticated access is available, fetch the canonical rules once, record the revision and read the task's chapters from that revision. This file is not the whole library and does not certify expertise or success.

## Own the design judgment

The owner should not need to teach the agent how to design a game, a shop, a clear interface or good feel. Establish the intended player experience, inspect the actual project and relevant original references, compare credible choices and explain why the chosen mechanism fits this game. For important choices retain a compact decision record: context, alternatives, mechanism, rules/sources, expected benefit, cost, actual evidence and what would change the decision. Reuse component-level decisions rather than generating paperwork for every pixel.

Separate owner requirements, platform guidance, study results, practitioner accounts, house hypotheses and actual project observations. An agent's self-review is not a player study. Passing tests does not establish enjoyment, beauty, acceptance or physical-device behavior. Never invent measurements or attribute our sample timing values to successful studios.

## Rebuild weak foundations before polishing

Owner instruction, 1 November 2026: sometimes starting from scratch is better than polishing a fundamentally weak result. Diagnose the root problem before changing small details. If the concept, mechanic, UX flow, art direction or architecture cannot reach the quality bar through incremental changes, stop micro-tweaking and compare targeted repair, substantial rework and a fresh implementation of the affected part. Choose by evidence, achievable quality and total remaining effort, including migration/regression risk. Work already spent is not a reason to keep a poor foundation.

Recommend and carry out the necessary rework within existing authorization. Prove a representative replacement before scaling it. Preserve useful assets, tests, history, saves and unrelated working features; a weak component does not automatically require a whole-project rewrite. Protected done work, destructive resets and scope expansion still need their specific authorization. The rule applies to all projects and adds no new approval round for rework already authorized.

## Five strong design principles

**No text.** Target zero visible text. Treat needing a label or explanation as a probable failure of intuitive mechanics, GUI, UX, affordance or shown teaching. Fix that cause first through objects, recognizable icons, shape/position/color, motion and feedback. A hand can demonstrate a mobile drag; then the player acts. Do not replace words with cryptic symbols or color-only essential cues. Every remaining word needs a concrete purpose after better presentation has been considered. Preserve exact purchase commitments, necessary notices and screen-reader semantics; these functional needs do not justify explanatory prose everywhere.

**Show, don't tell.** Reveal lore through world, assets, items, behavior, pacing, hints and consequences. Teach through notice, demonstration/opportunity, voluntary attempt, feedback, independent practice and later transfer. Let the player experiment, delay or decline. A challenge may require the learned skill without a tutorial taking over control or disabling unrelated actions solely to force obedience. Guide through landmarks, framing, light, motion, route shape and curiosity before adding directions.

**Fun first.** Every system exists to make play more enjoyable. Prove the core activity before progression or monetization. Balance matters when it improves fun, meaningful choices, expression, counterplay or fairness for the players involved. Equal numbers do not establish enjoyment. Preserve an exciting capability where possible while resolving the actual frustration. Quiet, cozy, clever and suspenseful experiences can all fulfil this principle.

**Rule of cool / Rule of cute.** Create a fantasy, action or character response worth seeing and repeating. Scientific plausibility and literal simulation do not veto a compelling idea. Show the distinctive capability in play. Use the owner's intended cool-led audience briefs and Sunrise's cute-led direction as project intentions to validate with actual players; do not treat gender as proof of preferences. Cool/cute effects still need readable action and coherent world behavior.

**Believable, not realism.** Flying desks, cushion friends and demon wars can all belong. Establish the world's accepted impossibilities, causal rules, time abstraction and motion/material language, then keep behavior and consequences consistent. In train games, compress travel/loading for fun while preserving convincing routes, departure/arrival, cargo transitions and operating rules. Jarring animation and unexplained contradictions break belief even when the world is stylized.

Read [the full principles](https://github.com/Superaids/general-rules/blob/main/game-dev-bible/38-FIVE-DESIGN-PRINCIPLES.md) and [worked cases](https://github.com/Superaids/general-rules/blob/main/game-dev-bible/examples/FIVE-PRINCIPLES-IN-PRACTICE.md). Apply within authorized scope and preserve protected done work.

## Build the activity before multiplying systems

State the core action, the meaningful choice it creates, why repeating it should be enjoyable, and how the player learns. Distinguish the core loop, session arc and longer progression. Add mechanics that create decisions or improve the experience; more currencies, screens and features are not automatically depth. Evaluate novice, experienced, free and returning play in relevant contexts rather than treating “casual” or “hardcore” as a complete audience definition.

Make challenge readable, failure instructive and retry/recovery proportionate. Vary learning, practice, combination, challenge and relief. Progression should earn understanding, capability, expression or meaningful choice rather than only larger numbers. Model resource sources/sinks and actual time/benefit with units. Do not manufacture gameplay pain to sell relief.

## Make actions feel excellent

Treat intention → input → state → visible/audible/tactile consequence as one chain. Acknowledge promptly; commit at the semantic point; separate authoritative state from decoration. Compose animation, sound, haptics and effects around a clear cause and significance. Anticipation, contact and recovery need appropriate weight. More shaking/particles and longer lockouts can harm clarity and repetition.

For a button specify focus/hover, press, release-inside, cancel, disabled, pending and error where relevant. Keep the hit area stable while artwork moves. Drag previews show the actual target, footprint, cost and legality; invalid release or interruption must not spend resources. Handle pointer cancellation, capture loss, app suspension and repeated input. A reward animation follows an idempotent authoritative grant and can never create duplicate ownership. Reduced-motion, mute and optional-haptic states preserve essential information.

Prototype numerical values are hypotheses. Tune in the actual game at normal pace and repeated use, including errors, dense scenes and weaker devices. Measure frame-time distributions and sustained heat, not only a flattering average FPS. A 60 FPS frame interval is about 16.67 ms; it is not a measured end-to-end latency claim.

## Make the interface belong to the game

Generic flat SaaS/dashboard cards are not an adequate default game UI. Choose a coherent material, silhouette, palette, type, object presentation and component family suited to the approved fantasy. Minimal/flat work can succeed when intentional and demonstrated in context. Ornament must not bury the task; clarity and crafted game identity should reinforce each other.

At each moment identify what the player must understand and act on: goal, available action, state, cost and consequence. Prioritize one focal task. Inspect actual size, movement, background contrast, long/localized text, loading and failure. Use more than color for important distinctions. Keep keyboard/controller focus complete and touch alternatives understandable. Art assets need consistent light, edges, scale, pivots, export rules and provenance, not just an attractive moodboard.

Choose portrait or landscape from the play envelope, simultaneous inputs, camera, grip and session context. Do not shrink a desktop layout uniformly onto a phone. Respect safe areas and finger occlusion. Apple points and Android dp differ from pixels; official guidance uses 44-point frequent touch targets on Apple and 48-dp targets on Android. These are platform design guidance, not proof of physical reach. Test representative devices/hands and accessibility settings; emulation is not a grip test.

## Offer desirable, honest value

Show the actual desirable object/use, exact contents and duration, clear localized cost, ownership/duplicate rules and understandable confirmation. Implement pending, cancellation, verified grant, restore, refund and failure. A store should feel like this game, with real objects and intentional hierarchy. Do not use fake discounts, hidden recurrence, guilt, deceptive scarcity or spending pressure. Evaluate satisfaction/regret and free-player play alongside revenue.

Rewarded ads are preferred, explicit and deliver the promised value. The owner's sole forced-ad exception allows a **very simple game whose primary model is ads plus no-ads** to use forced ads to encourage no-ads. This narrowly supersedes older blanket bans; choose from current research and game-specific evidence about retention/churn, regret, satisfaction and net value. Neither “ads always destroy retention” nor “ads do not affect retention” is established universally. Honour exact no-ads terms and store/network/age/privacy rules. A nonsignificant result does not prove no material harm.

## Learn through Sjouheim Pulse without false analytics or privacy claims

Maximize useful lawful anonymous aggregate insight. Read the [current integration](https://github.com/Superaids/Sjouheim-Pulse/blob/main/INTEGRATION.md), [API](https://github.com/Superaids/Sjouheim-Pulse/blob/main/API.md) and [collection review](https://github.com/Superaids/Sjouheim-Pulse/blob/main/docs/collection-review-2026-10-19.md). Define metrics by question, unit, denominator, source, permission/basis, dimensions, aggregation, retention and action. Use bounded fixed categories and suitable histograms/ratios. Preserve Test/Production separation, disabled-collection behavior, retries and weighted sums.

Session totals cannot yield exact unique players, cohorts, retention or concurrency. Public game telemetry is not verified money. Use suitable aggregate store/ad/accounting or separately reviewed sources for these metrics, with matched windows and uncertainty. ROI differs from ROAS; state net costs/refunds/fees and attribution limits. Unsupported or missing is not zero. Consenting players may not represent all players.

Persistent random IDs, hashes, small cells and transport/log metadata can remain personal data. First-party collection does not automatically remove device-access/consent rules. Assess actual audiences, territories, vendors and pipeline. Use supported lawful non-consent bases/exemptions where applicable, and consent where required; avoid unnecessary restrictions and unlawful shortcuts. No selling player data, covert cross-game tracking or misleading anonymity claims. Give a clear proportionate explanation matching actual behavior. This guide is not a legal certification or an instruction to silently enable SDKs.

## Preserve done work and use owner review when activated

Work marked done/accepted/completed is protected from direct and indirect changes unless specifically authorized by the owner. Map dependencies before new work. Adding a unit requires relevant checks of completed tutorial, roster/unlocks, saves, targeting and UI. Make the new work compatible; if changing a done surface is necessary, present that specific change for authorization. Backlog unrelated problems.

Near the end of production, the owner explicitly activates controlled review. A chat may recommend it with reasons; do not impose it on a new project. Once enabled, maintain one current review page with all pending old/new comparisons, comments, Approve and Send back with notes. Sprites require every frame, step/scrub and real in-game timing/playback. Maintain a highest-priority-first board: To do → In progress → In review → Approved to prod. Archive resolved/superseded items separately.

Approvals bind exact candidate and baseline versions. A tested bridge must deliver decisions to the intended chat, acknowledge and resume work. The chat applies the approved candidate through production verification, or adds returned notes to backlog work. A browser flag alone does not wake an idle chat; a click is not proof of deployment. Changed candidates/baselines need fresh review. These rules do not themselves activate a board or deploy a dispatcher.

## Read deeper by task

| Task | Canonical reference |
|---|---|
| Route the task | [Reading map](https://github.com/Superaids/general-rules/blob/main/game-dev-bible/READING-MAP.md) |
| Explain choices and assess quality | [Decision standard](https://github.com/Superaids/general-rules/blob/main/game-dev-bible/01-DECISION-STANDARD.md), [quality gates](https://github.com/Superaids/general-rules/blob/main/game-dev-bible/02-QUALITY-GATES.md) |
| Build concrete interactions | [Recipes](https://github.com/Superaids/general-rules/blob/main/game-dev-bible/patterns/INTERACTION-RECIPES.md) |
| Study pictures and materials | [Visual atlas](https://github.com/Superaids/general-rules/blob/main/game-dev-bible/28-REFERENCE-ATLAS.md) |
| See applied reasoning | [Worked decisions](https://github.com/Superaids/general-rules/blob/main/game-dev-bible/examples/WORKED-DECISIONS.md) |
| Inspect original evidence | [Sources and limitations](https://github.com/Superaids/general-rules/blob/main/game-dev-bible/SOURCES.md) |

Useful original foundations available independently: [Celeste forgiveness](https://www.maddymakesgames.com/articles/celeste_and_forgiveness/index.html), [Valve art clarity](https://cdn.fastly.steamstatic.com/apps/valve/2008/GDC2008_StylizationWithAPurpose_TF2.pdf), [King level design](https://media.gdcvault.com/gdceurope2016/presentations/KANG_Jeremy_LevelDesignSaga.pdf), [Valve playtesting](https://cdn.fastly.steamstatic.com/apps/valve/2009/GDC2009_ValvesApproachToPlaytesting.pdf), [Apple game controls](https://developer.apple.com/design/human-interface-guidelines/game-controls), [Xbox accessibility](https://learn.microsoft.com/en-us/xbox/accessibility/guidelines), [GDPR primary text](https://eur-lex.europa.eu/legal-content/EN/TXT/HTML/?uri=CELEX:32016R0679) and [Danish device-analytics guidance](https://www.datatilsynet.dk/regler-og-vejledning/cookies-og-lignende-teknologier/gode-raad-ved-brug-af-cookies-og-lignende-teknologier). Recheck changing requirements before shipping.
