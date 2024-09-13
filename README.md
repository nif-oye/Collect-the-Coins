# Collect-the-Coins
In this mini-project, a simple coin collection system was developed where the player collects coins, triggering an audio sound. The core components involve using Unity's OnTriggerEnter method to detect player collisions with the coins and playing a sound upon collection.

Key learnings include:
- Using colliders and the OnTriggerEnter method to handle interactions.
- AudioSource management to play sounds effectively without cutting off audio, ensuring smooth gameplay.
- Employing PlayOneShot() for overlapping sound effects, preventing interruptions when multiple coins are collected quickly.
- Using Destroy() to immediately remove collected objects while allowing the audio to play fully.
