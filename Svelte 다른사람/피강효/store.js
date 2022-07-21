import { writable } from 'svelte/store';

export const page = writable("home");
export const reactionS=writable(100000)
export const sequenceS=writable(0)



