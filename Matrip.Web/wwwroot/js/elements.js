/* JS Document */

/******************************

[Table of Contents]

1. Vars and Inits
2. Set Header
3. Init Menu
4. Init Accordions
5. Init Tabs
6. Init Loaders
7. Init Milestones


******************************/

jQuery(document).ready(function()
{
	"use strict";

	/* 

	1. Vars and Inits

	*/

	var header = jQuery('.header');
	var ctrl = new ScrollMagic.Controller();

	setHeader();

	jQuery(window).on('resize', function()
	{
		setHeader();

		setTimeout(function()
		{
			jQuery(window).trigger('resize.px.parallax');
		}, 375);
	});

	jQuery(document).on('scroll', function()
	{
		setHeader();
	});

	initMenu();
	initAccordions();
	initTabs();
	initLoaders();
	initMilestones();

	/* 

	2. Set Header

	*/

	function setHeader()
	{
		if(jQuery(window).scrollTop() > 91)
		{
			header.addClass('scrolled');
		}
		else
		{
			header.removeClass('scrolled');
		}
	}

	/* 

	3. Init Menu

	*/

	function initMenu()
	{
		if(jQuery('.menu').length)
		{
			var header = jQuery('.header');
			var hOverlay = jQuery('.header_overlay');
			var menu = jQuery('.menu');
			var hamb = jQuery('.hamburger');
			var sup = jQuery('.super_container_inner');
			var close = jQuery('.menu_close');
			var overlay = jQuery('.super_overlay');

			hamb.on('click', function()
			{
				header.toggleClass('active');
				sup.toggleClass('active');
				menu.toggleClass('active');
			});

			close.on('click', function()
			{
				header.toggleClass('active');
				sup.toggleClass('active');
				menu.toggleClass('active');
			});

			overlay.on('click', function()
			{
				header.toggleClass('active');
				sup.toggleClass('active');
				menu.toggleClass('active');
			});

			hOverlay.on('click', function()
			{
				header.toggleClass('active');
				sup.toggleClass('active');
				menu.toggleClass('active');
			});
		}
	}

	/* 

	4. Init Accordions

	*/

	function initAccordions()
	{
		if(jQuery('.accordion').length)
		{
			var accs = jQuery('.accordion');

			accs.each(function()
			{
				var acc = jQuery(this);

				if(acc.hasClass('active'))
				{
					var panel = jQuery(acc.next());
					var panelH = panel.prop('scrollHeight') + "px";
					
					if(panel.css('max-height') == "0px")
					{
						panel.css('max-height', panel.prop('scrollHeight') + "px");
					}
					else
					{
						panel.css('max-height', "0px");
					} 
				}

				acc.on('click', function()
				{
					if(acc.hasClass('active'))
					{
						acc.removeClass('active');
						var panel = jQuery(acc.next());
						var panelH = panel.prop('scrollHeight') + "px";
						
						if(panel.css('max-height') == "0px")
						{
							panel.css('max-height', panel.prop('scrollHeight') + "px");
						}
						else
						{
							panel.css('max-height', "0px");
						} 
					}
					else
					{
						acc.addClass('active');
						var panel = jQuery(acc.next());
						var panelH = panel.prop('scrollHeight') + "px";
						
						if(panel.css('max-height') == "0px")
						{
							panel.css('max-height', panel.prop('scrollHeight') + "px");
						}
						else
						{
							panel.css('max-height', "0px");
						} 
					}
				});
			});
		}
	}

	/* 

	5. Init Tabs

	*/

	function initTabs()
	{
		if(jQuery('.tab').length)
		{
			jQuery('.tab').on('click', function()
			{
				jQuery('.tab').removeClass('active');
				jQuery(this).addClass('active');
				var clickedIndex = jQuery('.tab').index(this);

				var panels = jQuery('.tab_panel');
				panels.removeClass('active');
				jQuery(panels[clickedIndex]).addClass('active');
			});
		}
	}

	/* 

	6. Init Loaders

	*/

	function initLoaders()
	{
		if(jQuery('.loader').length)
		{
			var loaders = jQuery('.loader');

			loaders.each(function()
			{
				var loader = this;
				var endValue = jQuery(loader).data('perc');

				var loaderScene = new ScrollMagic.Scene({
		    		triggerElement: this,
		    		triggerHook: 'onEnter',
		    		reverse:false
		    	})
		    	.on('start', function()
		    	{
		    		var bar = new ProgressBar.Circle(loader,
					{
						color: '#ffae00',
						// This has to be the same size as the maximum width to
						// prevent clipping
						strokeWidth: 6.5,
						trailWidth: 0,
						trailColor: 'transparent',
						easing: 'easeInOut',
						duration: 1400,
						text:
						{
							autoStyleContainer: false
						},
						from:{ color: '#ffae00', width: 6.5 },
						to: { color: '#ffae00', width: 6.5 },
						// Set default step function for all animate calls
						step: function(state, circle)
						{
							circle.path.setAttribute('stroke', state.color);
							circle.path.setAttribute('stroke-width', state.width);

							var value = Math.round(circle.value() * 100);

							if (value === 0)
							{
								circle.setText('0%');
							}
							else
							{
								circle.setText(value + "%");
							}
						}
					});


					bar.animate(endValue);  // Number from 0.0 to 1.0
		    	})
			    .addTo(ctrl);
			});
		}
	}

	/* 

	7. Init Milestones

	*/

	function initMilestones()
	{
		if(jQuery('.milestone_counter').length)
		{
			var milestoneItems = jQuery('.milestone_counter');

	    	milestoneItems.each(function(i)
	    	{
	    		var ele = jQuery(this);
	    		var endValue = ele.data('end-value');
	    		var eleValue = ele.text();

	    		/* Use data-sign-before and data-sign-after to add signs
	    		infront or behind the counter number */
	    		var signBefore = "";
	    		var signAfter = "";

	    		if(ele.attr('data-sign-before'))
	    		{
	    			signBefore = ele.attr('data-sign-before');
	    		}

	    		if(ele.attr('data-sign-after'))
	    		{
	    			signAfter = ele.attr('data-sign-after');
	    		}

	    		var milestoneScene = new ScrollMagic.Scene({
		    		triggerElement: this,
		    		triggerHook: 'onEnter',
		    		reverse:false
		    	})
		    	.on('start', function()
		    	{
		    		var counter = {value:eleValue};
		    		var counterTween = TweenMax.to(counter, 4,
		    		{
		    			value: endValue,
		    			roundProps:"value", 
						ease: Circ.easeOut, 
						onUpdate:function()
						{
							document.getElementsByClassName('milestone_counter')[i].innerHTML = signBefore + counter.value + signAfter;
						}
		    		});
		    	})
			    .addTo(ctrl);
	    	});
		}
	}

});