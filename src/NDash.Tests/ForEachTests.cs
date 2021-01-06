using System;
using System.Collections.Generic;
using NDash.Tests.TestClasses;
using Xunit;

namespace NDash.Tests
{
    public class ForEachTests
    {
        public class Arity1
        {
            IEnumerable<Developer> _devs;
            Action<Developer> _action1;
            Action<Developer, int> _action2;
            int _arity;

            [Fact]
            public void ARITY_1_should_execute_action_on_all_items()
            {
                given_3_devs();
                given_action_with_arity(1);

                when_all_actions_succeed();

                then_function_should_return_void();
            }

            [Fact]
            public void ARITY_1_should_quit_if_action_throws_exception()
            {
                given_3_devs();
                given_action_with_arity(1);

                when_action_fails_on_second_item();

                then_function_should_throw_that_exception();
            }
            [Fact]
            public void ARITY_2_should_execute_action_on_all_items()
            {
                given_3_devs();
                given_action_with_arity(2);

                when_all_actions_succeed();

                then_function_should_return_void();
            }

            [Fact]
            public void ARITY_2_should_quit_if_action_throws_exception()
            {
                given_3_devs();
                given_action_with_arity(2);

                when_action_fails_on_second_item();

                then_function_should_throw_that_exception();
            }

            void then_function_should_return_void()
            {
                _devs.ForEach(_action1);

                Assert.True(true);
            }

            void when_all_actions_succeed()
            {
                _action1 = NDashLib.Noop;
                _action2 = NDashLib.Noop;
            }

            void given_action_with_arity(int arity)
            {
                _arity = arity;
            }

            void given_3_devs()
            {
                _devs = new[]
                {
                    new Developer("John", "Doe", 30),
                    new Developer("Jane", "Doe", 35),
                    new Developer("Qwerty", "Dvorak", 40),
                };
            }

            void then_function_should_throw_that_exception()
            {
                try
                {
                    if (_arity == 1)
                    {
                        _devs.ForEach(_action1);
                    }
                    else
                    {
                        _devs.ForEach(_action2);
                    }
                }
                catch(Exception e)
                {
                    Assert.Equal("Error! Dev is old!", e.Message);
                }
            }

            void when_action_fails_on_second_item()
            {
                _action1 = dev =>
                {
                    if (dev.Age == 35)
                    {
                        throw new Exception("Error! Dev is old!");
                    }
                };
                _action2 = (dev, i) =>
                {
                    if (dev.Age == 35)
                    {
                        throw new Exception("Error! Dev is old!");
                    }
                };
            }
        }
    }
}
