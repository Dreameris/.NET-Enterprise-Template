namespace templateproject.Infrastructure.Log
{
    using Machine.Specifications;
    using Moq;
    using It=Machine.Specifications.It;

    [Subject(typeof(LogFactory), "create a logger for context of specification"), Tags("Infrastructure.Log")]
    public class when_given_a_log_factory
    {
        Because of = () => logger = LogFactory.GetSpecificationLogger();

        It should_call_getlogger_of_proxy;  // TODO : static method�� ȣ���� ������ �� �ִ� ����� ã�� �����ؾ� �Ѵ�.
        It should_return_a_logger = () => logger.ShouldNotBeNull();

        private static ILog logger;
    }
}