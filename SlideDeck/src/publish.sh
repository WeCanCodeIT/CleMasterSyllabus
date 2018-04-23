. ./slideshow_env.sh

bundle install

target=../docs/$1

bundle exec slideshow -c $slideshow_config_folder update

if [ ! -e "$template_folder/wcci.txt" ]; then
	git clone https://github.com/WeCanCodeIT/wcci-slideshow-template $template_folder
fi

rm -rf $target

bundle exec slideshow -c ../slideshow-config build -t wcci ./$1/index.md -o $target

# copy resources
mkdir -p $target/resources
cp -r ./$1/resources/* $target/resources