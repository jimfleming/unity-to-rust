DYLIB=target/debug/libunity_rust.dylib
BUNDLE=unity-example/Assets/Plugins/libunity_rust.bundle

all: $(DYLIB) $(BUNDLE)

$(DYLIB): src/lib.rs Cargo.toml
	cargo build

$(BUNDLE): $(DYLIB)
	cp $< $@

clean:
	rm -rf target/
	rm -f $(BUNDLE)
	rm -f $(BUNDLE).meta
