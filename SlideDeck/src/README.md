Must have slideshow (S9) ruby gem installed. If you have problems with slideshow generation, it could be the version of liquid, may need to roll back.

To publish a slideshow (from `/src`):

```bash
./publish.sh <path_to_index>
```

Frex, `./publish.sh foo/bar` will publish `src/foo/bar/index.md` to `docs/foo/bar/index.html`.

Note: the publishing strategy/template expects sources that follow the pattern `/<category>/<deck>/index.md`.