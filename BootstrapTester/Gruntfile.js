/// <vs SolutionOpened='watch' />

module.exports = function (grunt) {
    grunt.initConfig({

        src:    {   path: 'assets/src'  },
        dist:   {   path: 'assets/dist'  },

        clean: {
            css: ["<%= dist.path %>/css/*"],
            js: ["<%= dist.path %>/js/*"]
        },

        less: {
            options: {
                outputStyle: 'nested'
            },

            site: {
                //each less file under "site" will have its own css file
                files: [{
                    expand: true,
                    src: ['<%= src.path %>/site/less/*.less'],
                    dest: '<%= dist.path %>/css/',
                    ext: '.css',
                    extDot: 'first',
                    flatten: true
                }]
            },

            bootstrap: {
                files: {'<%= dist.path %>/css/bootstrap.css': ['<%= src.path %>/bootstrap/less/bootstrap.less']}
            },

            hover: {
                files: {'<%= dist.path %>/css/hover.css': '<%= src.path %>/hover/less/hover.less'}
            },

        },

        cssmin: {
            minify: {
                //each css file will have min version
                expand: true,
                cwd: '<%= dist.path %>/css/',
                src: ['*.css', '!*.min.css'],
                dest: '<%= dist.path %>/css/',
                ext: '.min.css',
                extDot: 'last'
            }
        },

        concat: {
            options: {
                separator: ';',
            },

            boostrap_datetimepicker: {
                src: [
                    "<%= src.path %>/bootstrap-datetimepicker/js/moment.js",
                    "<%= src.path %>/bootstrap-datetimepicker/js/bootstrap-datetimepicker.js"
                ],
                dest: "<%= dist.path %>/js/bootstrap-datetimepicker.all.js"
            },

            jquery: {
                src: ["<%= src.path %>/jquery/jquery*.js"],
                dest: "<%= dist.path %>/js/jquery.js"
            },

            jquery_validate: {
                src: [
                    "<%= src.path %>/jquery/validate/jquery.validate.js",
                    "<%= src.path %>/jquery/validate/jquery.validate.unobtrusive.js",
                    "<%= src.path %>/jquery/validate/_extensions.js"
                ],
                dest: "<%= dist.path %>/js/jquery.validate.all.js"
            },
        },

        uglify: {
            options: {
                // the banner is inserted at the top of the output
                //banner: '/*! <%= pkg.name %> <%= grunt.template.today("dd-mm-yyyy") %> */\n'
            },
            dist: {
                options: {
                    compress: false,
                    mangle: false
                },
                files: [
                    {
                        //each js file will have a min version
                        expand: true,
                        cwd: '<%= dist.path %>/js/',
                        src: ['*.js', '!*.min.js'],
                        dest: '<%= dist.path %>/js/',
                        ext: '.min.js',
                        extDot: 'last'
                    }
                ]
            }
        },

        copy: {
            fonts: {
                cwd: '<%= src.path %>',  // set working folder / root to copy
                src: '*/fonts/*',           // copy all files and subfolders
                dest: '<%= dist.path %>/fonts/',    // destination folder
                expand: true,           // required when using cwd,
                flatten: true,
                filter: 'isFile'
            },

            font_awesome: {
                src: ['<%= src.path %>/fontawesome/font-awesome.css'],
                dest: '<%= dist.path %>/css/font-awesome.css'
            },

            bootstrap: {
                src: ["<%= src.path %>/bootstrap/js/bootstrap.js"],
                dest: "<%= dist.path %>/js/bootstrap.js"
            },
        },

        watch: {
            scripts: {
                files: ['<%= src.path %>/**/*.js'],
                tasks: ['clean:js', 'concat', 'uglify'],
                options: {
                    spawn: false,
                },
            },

            styles: {
                files: ['<%= src.path %>/**/*.{scss,sass,css,less}'],
                tasks: ['clean:css', 'copy:font_awesome', 'less', 'cssmin'],
                options: {
                    spawn: false,
                },
            }
        },

    });


    grunt.loadNpmTasks("grunt-contrib-clean");
    grunt.loadNpmTasks("grunt-contrib-less");
    grunt.loadNpmTasks("grunt-contrib-concat");
    grunt.loadNpmTasks("grunt-contrib-cssmin");
    grunt.loadNpmTasks("grunt-contrib-uglify");
    grunt.loadNpmTasks("grunt-contrib-copy");

    grunt.loadNpmTasks("grunt-contrib-watch");

    grunt.registerTask('default', ['clean', 'less', 'concat', 'copy', 'cssmin', 'uglify']);

    //grunt.registerTask('watch', ['watch']);

    
};

